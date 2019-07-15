import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsereListComponent } from './users/usere-list/usere-list.component';
import { LikesComponent } from './likes/likes.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent},
    { path: 'uzytkownicy', component: UsereListComponent, canActivate: [AuthGuard]},
    { path: 'polubienia', component: LikesComponent, canActivate: [AuthGuard]},
    { path: 'wiadomosci', component: MessagesComponent, canActivate: [AuthGuard]},
    { path: '**', redirectTo: 'home', pathMatch: 'full'},
];
