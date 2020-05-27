import {Component, EventEmitter, OnDestroy, OnInit, Output, ViewChild} from '@angular/core';
import {Subscription, timer} from 'rxjs/index';
import {NgForm} from '@angular/forms';
import {RegisterLoginService} from '../../register-login/register-login.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit, OnDestroy {
  @ViewChild('form') form: NgForm;
  private a: number;
  private b: number;
  private c: number;
  private answers: number[] = [];
  public questions: string[] = [];
  @Output() gameStarted =  new EventEmitter<boolean>();
  public timeLeft = 60;
  public subscribeTimer: number;
  public currentRemaingSec: number;
  public score: number;
  public started: boolean;
  abc: Subscription;
  constructor(private registerLoginService: RegisterLoginService) {}
  ngOnInit() {
    this.started = true;
    this.a = Math.floor(Math.random() * 10) + 1;
    this.b = Math.floor(Math.random() * 30) + 1;
    this.questions.push('Q1)  2 * ' + this.a + ' + 3 * (2 - ' + this.b + ') = ?');
    this.answers.push(this.q1(this.a, this.b));

    this.a = Math.floor(Math.random() * 12) + 1;
    this.b = Math.floor(Math.random() * 10) + 1;
    this.questions.push('Q2)  2 * ' + this.a + ' + 0 * (' + this.b + ' + ' + this.a + ') = ?');
    this.answers.push(this.q2(this.a));

    this.a = Math.floor(Math.random() * 5) + 1;
    this.b = Math.floor(Math.random() * 5) + 1;
    this.c = Math.floor(Math.random() * 5) + 1;
    this.questions.push('Q3)  ' + this.a + ' + ' + this.b + ' - ' + this.c + ' = ?');
    this.answers.push(this.q3(this.a, this.b, this.c));

    this.a = Math.floor(Math.random() * 5) + 1;
    this.b = Math.floor(Math.random() * 20) + 1;
    this.questions.push('Q4)  (' + this.a + ' + ' + this.b + ') * 2 = ?');
    this.answers.push(this.q4(this.a, this.b));

    this.a = Math.floor(Math.random() * 5) + 1;
    this.b = Math.floor(Math.random() * 30) + 1;
    this.c = Math.floor(Math.random() * 5) + 1;
    this.questions.push('Q5)  4 * ' + this.a + ' + 2 * ' + this.b + ' + ' + this.c + ' = ?');
    this.answers.push(this.q5(this.a, this.b, this.c));

    this.a = Math.floor(Math.random() * 100) + 1;
    this.b = Math.floor(Math.random() * 300) + 1;
    this.questions.push('Q6)  ' + this.a + ' + ' + this.b + ' = ?');
    this.answers.push(this.q6(this.a, this.b));

    this.a = Math.floor(Math.random() * 5) + 1;
    this.b = Math.floor(Math.random() * 5) + 1;
    this.c = Math.floor(Math.random() * 30) + 1;
    this.questions.push('Q7)  ' + this.a + ' - ' + this.b + ' - ' + this.c + ' = ?');
    this.answers.push(this.q7(this.a, this.b, this.c));

    this.a = Math.floor(Math.random() * 10) + 1;
    this.b = Math.floor(Math.random() * 10) + 1;
    this.c = Math.floor(Math.random() * 8) + 1;
    this.questions.push('Q8)  (' + this.a + ' + ' + this.b + ') - ' + this.c + ' = ?');
    this.answers.push(this.q8(this.a, this.b, this.c));

    this.a = Math.floor(Math.random() * 20) + 1;
    this.b = Math.floor(Math.random() * 20) + 1;
    this.c = Math.floor(Math.random() * 8) + 1;
    this.questions.push('Q9)  1 - ' + this.a + ' + ' + this.b + ' * ' + this.c + ' = ?');
    this.answers.push(this.q9(this.a, this.b, this.c));

    this.a = Math.floor(Math.random() * 200) + 1;
    this.b = Math.floor(Math.random() * 20) + 1;
    this.c = Math.floor(Math.random() * 100) + 1;
    this.questions.push('Q10)  (' + this.a + ' - ' + this.b + ' + 0 * ' + this.c + ') * 1 = ?');
    this.answers.push(this.q10(this.a, this.b));
    this.oberserableTimer();
  }
  q1(a: number, b: number) {
    return 2 * a + 3 * (2 - b);
  }
  q2(a: number) {
    return 2 * a;
  }
  q3(a: number, b: number, c: number) {
    return a + b - c;
  }
  q4(a: number, b: number) {
    return (a + b) * 2;
  }
  q5(a: number, b: number, c: number) {
    return 4 * a + 2 * b + c;
  }
  q6(a: number, b: number) {
    return a + b;
  }
  q7(a: number, b: number, c: number) {
    return a - b - c;
  }
  q8(a: number, b: number, c: number) {
    return (a + b) - c;
  }
  q9(a: number, b: number, c: number) {
    return 1 - a + b * c;
  }
  q10(a: number, b: number) {
    return a - b;
  }
  onSubmit() {
    const formAnswers = [];
    formAnswers.push(this.form.value.q1);
    formAnswers.push(this.form.value.q2);
    formAnswers.push(this.form.value.q3);
    formAnswers.push(this.form.value.q4);
    formAnswers.push(this.form.value.q5);
    formAnswers.push(this.form.value.q6);
    formAnswers.push(this.form.value.q7);
    formAnswers.push(this.form.value.q8);
    formAnswers.push(this.form.value.q9);
    formAnswers.push(this.form.value.q10);

    let counter = 0;
    for (let i = 0; i < this.answers.length; i++) {
      if ( this.answers[i] === formAnswers[i]) {
        counter++;
      }
    }
    this.calculateScore(counter);
    if (this.subscribeTimer !== 0) {
      alert('Your score is ' + this.score + '!');
    } else {
      alert('Timeout, your score is ' + this.score + '!');
    }
    this.registerLoginService.updateScore(this.score);
    this.started = false;
    this.gameStarted.emit(this.started);
  }

 oberserableTimer() {
    const source = timer(1000, 1000);
    this.abc = source.subscribe(val => {
      this.currentRemaingSec = val;
      this.subscribeTimer = this.timeLeft - val;
      if (this.subscribeTimer === 0) {
        this.onSubmit();
      }
    });
  }
  calculateScore(counter: number) {
    let boostedNumber = 0;
    if (counter === 10) {
      boostedNumber = 512;
    } else if (counter === 9) {
      boostedNumber = 256;
    } else if (counter === 8) {
      boostedNumber = 128;
    } else if (counter === 7) {
      boostedNumber = 64;
    } else if (counter === 6) {
      boostedNumber = 32;
    } else if (counter === 5) {
      boostedNumber = 16;
    } else if (counter === 4) {
      boostedNumber = 8;
    } else if (counter === 3) {
      boostedNumber = 4;
    } else if (counter === 2) {
      boostedNumber = 2;
    } else if (counter === 1) {
      boostedNumber = 1;
    }
    this.score = Math.max(1, this.subscribeTimer) * boostedNumber;
  }
  ngOnDestroy() {
    this.abc.unsubscribe();
  }
}
