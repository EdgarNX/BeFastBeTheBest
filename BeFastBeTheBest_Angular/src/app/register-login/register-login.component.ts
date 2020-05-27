import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';
import {Observable} from 'rxjs/index';
import {Router} from '@angular/router';
import {RegisterLoginResponseData, RegisterLoginService} from './register-login.service';
import {ScoreModel} from "../game-page/score.model";

@Component({
  selector: 'app-register-login',
  templateUrl: './register-login.component.html',
  styleUrls: ['./register-login.component.css']
})
export class RegisterLoginComponent implements OnInit {

  isLoginMode = true;
  isLoading = false;
  isForgettingMode = false;
  error: string = null;

  constructor(private registerLoginService: RegisterLoginService, private router: Router) { }

  ngOnInit() {
    localStorage.removeItem('userData');
    this.registerLoginService.userData = null;
  }

  onSwitchMode() {
    this.isLoginMode = !this.isLoginMode;
  }

  onSubmit(form: NgForm) {
    if (!form.valid) {
      return;
    }
    const nickname = form.value.nickname;
    const password = form.value.password;

    let reglogObs: Observable<string>;

    this.isLoading = true;

    if (this.isLoginMode) {
       reglogObs = this.registerLoginService.login(nickname, password);
    } else {
      reglogObs = this.registerLoginService.signUp(nickname, password);
    }
    reglogObs.subscribe(
      resData => {
        if (resData === 'User already exists!') {
          this.error = 'User already exists!';
          this.isLoading = false;
        } else if (resData === 'Wrong password!') {
          this.error = 'Wrong password!';
          this.isLoading = false;
        } else if (resData === 'User not found!') {
          this.error = 'User not found!';
          this.isLoading = false;
        } else {
          this.registerLoginService.handleAuthentication(JSON.stringify(resData));
          localStorage.setItem('userData', JSON.stringify(resData));
          this.isLoading = false;
          this.router.navigate(['game']);
        }
      }
    );
    form.reset();
  }
}
