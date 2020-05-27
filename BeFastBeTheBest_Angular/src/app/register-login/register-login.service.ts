import {EventEmitter, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Subject, throwError} from 'rxjs';
import {catchError} from 'rxjs/operators';
import {Router} from '@angular/router';
import {map} from 'rxjs/internal/operators';
import {ScoreModel} from '../game-page/score.model';
import {User} from './user.model';

export interface RegisterLoginResponseData {
  nickname: string;
  password: string;
}

@Injectable({providedIn: 'root'})
export class RegisterLoginService {
  usersChanged = new EventEmitter<ScoreModel[]>();
  users: ScoreModel[] = [];
  userData: any;
  public theUser = new Subject<User>();
  constructor(private http: HttpClient, private router: Router) {}

  async delay(ms: number) {
    await new Promise(resolve => setTimeout(() => resolve(), ms)).then(() => {
      this.usersChanged.emit(this.users.slice());
      return this.users.slice();
    });
  }

  signUp(name: string, password: string) {
    return this.http.post<string>(
      'https://userapi20200519105404.azurewebsites.net/api/users',
      {
        name,
        password
      },
      { responseType: 'text' as 'json' }
    ).pipe(
      map(el => {
        return el;
      }),
      catchError(err => {
        return throwError(err.message);
      })
    );
  }

  login(name: string, password: string) {
    return this.http.post<string>(
      'https://userapi20200519105404.azurewebsites.net/api/users/login',
      {
        name,
        password
      },
      { responseType: 'text' as 'json' }
    ).pipe(
      map(el => {
        return el;
      }),
      catchError(err => {
        return throwError(err.message);
      })
    );
  }

  get user(): Subject<User> {
    return this.theUser;
  }

  getAllUsers() {
    this.http.get<ScoreModel[]>('https://scoreapi20200520112737.azurewebsites.net/api/scores').subscribe(
      async (resData) => {
        JSON.parse(JSON.stringify(resData)).forEach(r => {
          this.users.push(new ScoreModel(r.userName, r.points));
          this.delay(500);
        });
      }
    );
  }

  deleteFromDB(nickname: string) {
    return this.http.delete<string>(
      'https://userapi20200519105404.azurewebsites.net/api/users/' + nickname,
      { responseType: 'text' as 'json' }
    ).pipe(
      map(el => {
        return el;
      }),
      catchError(err => {
        return throwError(err.message);
      })
    );
  }

  handleAuthentication(nickname: any) {
    this.theUser.next(new User(nickname));
    localStorage.setItem('userData', JSON.stringify(nickname));
  }

  autoLogin() {
      const userData: {
        nickname: string;
      } = JSON.parse(localStorage.getItem('userData'));
      if (!userData) {
        return;
      }
      this.handleAuthentication(userData);
  }

  updateScore(score: number) {
    this.http.put(
      'https://scoreapi20200520112737.azurewebsites.net/api/scores/' +
      localStorage.getItem('userData').substring(1, localStorage.getItem('userData').length - 1) + '/' + score,
      {
      name
      }
      ).subscribe(
      resData => {
        console.log(resData);
        JSON.parse(JSON.stringify(resData)).forEach(r => {
          this.users.push(new ScoreModel(r.userName, r.points));
        });
      }
    );
    for (const i of this.users) {
      if (i.userName === localStorage.getItem('userData').substring(1, localStorage.getItem('userData').length - 1) && i.points < score) {
        i.points = score;
        const index = this.users.indexOf(i);
        this.users[index] = i;
      }
    }
    for (let i = 0; i < this.users.length - 1; i++) {
      for (let j = i; j < this.users.length; j++) {
        if (this.users[i].points < this.users[j].points) {
          const aux = this.users[i].points;
          this.users[i].points = this.users[j].points;
          this.users[j].points = aux;

          const temporary = this.users[i].userName;
          this.users[i].userName = this.users[j].userName;
          this.users[j].userName = temporary;
        }
      }
    }
    this.usersChanged.emit(this.users.slice());
  }

  logout() {
      this.user.next(null);
      localStorage.removeItem('userData');
      this.router.navigate(['/register-login']);
  }
}

