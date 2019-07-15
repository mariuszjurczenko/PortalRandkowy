import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsereListComponent } from './users/usere-list/usere-list.component';
import { LikesComponent } from './likes/likes.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    { path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
        { path: 'uzytkownicy', component: UsereListComponent},
        { path: 'polubienia', component: LikesComponent},
        { path: 'wiadomosci', component: MessagesComponent},
      ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'},
];
