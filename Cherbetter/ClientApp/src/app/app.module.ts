import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { TicketComponent } from './ticket/ticket.component';
import { AddTicketComponent } from './add-ticket/add-ticket.component';
import { TicketDetailComponent } from './ticket-detail/ticket-detail.component';
import { FavoriteComponent } from './favorite/favorite.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    TicketComponent,
    AddTicketComponent,
    TicketDetailComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'ticket/:email', component: FavoriteComponent },
      { path: 'ticket/:id', component: TicketDetailComponent },
      { path: 'ticket/add', component: AddTicketComponent },
      { path: 'ticket', component: TicketComponent },
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [TicketComponent, AddTicketComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
