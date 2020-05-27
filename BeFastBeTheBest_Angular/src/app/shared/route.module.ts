import { RouterModule, Routes} from '@angular/router';
import {RegisterLoginComponent} from '../register-login/register-login.component';
import {GamePageComponent} from '../game-page/game-page.component';
import {NgModule} from '@angular/core';

const appRoutes: Routes = [
  { path: '', redirectTo: 'register-login', pathMatch: 'full' },
  { path: 'register-login', component: RegisterLoginComponent },
  { path: 'game', component: GamePageComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule],
})

export class AppRoutingModule { }


