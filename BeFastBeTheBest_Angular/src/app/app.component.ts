import {Component, OnDestroy, OnInit} from '@angular/core';
import {RegisterLoginService} from './register-login/register-login.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'BeFastBeTheBest';
  loadedFeature = 'register/login';
  constructor(private registerLoginService: RegisterLoginService) {
  }
  ngOnInit(): void {
    this.registerLoginService.autoLogin();
  }
  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }
  ngOnDestroy(): void {
     this.registerLoginService.logout();
  }
}
