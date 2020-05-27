import { Component, OnInit } from '@angular/core';
import {RegisterLoginService} from '../register-login/register-login.service';
import {ScoreModel} from './score.model';

@Component({
  selector: 'app-game-page',
  templateUrl: './game-page.component.html',
  styleUrls: ['./game-page.component.css']
})
export class GamePageComponent implements OnInit {
  public loadedOption: string;
  public showForm: boolean;
  public gameStarted: boolean;
  nickname: string;
  users: ScoreModel[];

  constructor(private registerLoginService: RegisterLoginService) {
    this.loadedOption = 'list';
  }

  ngOnInit(): void {
    this.registerLoginService.autoLogin();
    this.loadedOption = 'list';
    this.showForm = true;
    this.nickname = localStorage.getItem('userData').substring(1, localStorage.getItem('userData').length - 1);
    this.users = this.registerLoginService.users;

    this.registerLoginService.getAllUsers();
    this.registerLoginService.usersChanged
      .subscribe(
        (usersChanged: ScoreModel[]) => {
          this.users = usersChanged;
        }
      );
  }

  onStart() {
    this.gameStarted = true;
  }

  onStop() {
    this.gameStarted = false;
  }
}
