import {Component, EventEmitter, OnDestroy, OnInit, Output} from '@angular/core';
import {Observable, Subscription} from 'rxjs';
import {Router} from '@angular/router';
import {RegisterLoginService} from '../register-login/register-login.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit, OnDestroy {
  @Output() featureSelected = new EventEmitter<string>();

  isAuthenticated = false;
  authenticatedNickname: string;
  private userSub: Subscription;

  constructor(
    private registerLoginService: RegisterLoginService,
    private router: Router,
  ) { }

  public ngOnInit(): void {
    this.registerLoginService.autoLogin();

    this.userSub = this.registerLoginService.user.subscribe(user => {
      this.isAuthenticated = !!user;
      this.authenticatedNickname = user.nickname;
    });
  }
  onSelect(feature) {
     this.featureSelected.emit(feature);
  }

  onLogout() {
     this.registerLoginService.logout();
  }

  onDeleteAccount() {
    if (window.confirm('Are you sure you wanna delete this account?')) {
      let registerLoginObs: Observable<string>;
      registerLoginObs = this.registerLoginService.deleteFromDB(
        localStorage.getItem('userData').substring(1, localStorage.getItem('userData').length - 1)
      );
      registerLoginObs.subscribe(
        resData => {
          if (resData === 'Something went wrong!') {
            console.log(resData);
          } else if (resData === 'User not found!') {
            console.log(resData);
          } else if (resData === 'User was deleted successfully!') {
            for (const i of this.registerLoginService.users) {
              if (i.userName === localStorage.getItem('userData').substring(1, localStorage.getItem('userData').length - 1)) {
                const index = this.registerLoginService.users.indexOf(i);
                this.registerLoginService.users.splice(index, 1);
              }
            }
            this.registerLoginService.usersChanged.emit(this.registerLoginService.users.slice());
            localStorage.removeItem('userData');
            this.router.navigate(['register-login']);
          }
        }
      );
    }
  }
  ngOnDestroy(): void {
    this.userSub.unsubscribe();
  }
}

