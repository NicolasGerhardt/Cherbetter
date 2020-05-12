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
<<<<<<< HEAD
import { TicketDetailComponent } from './ticket-detail/ticket-detail.component';
=======
>>>>>>> bc2f7f2a933fda4757550676302c436a899eee86

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    TicketComponent,
<<<<<<< HEAD
    AddTicketComponent,
    TicketDetailComponent
=======
    AddTicketComponent
>>>>>>> bc2f7f2a933fda4757550676302c436a899eee86
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
<<<<<<< HEAD
      { path: 'ticket/:id', component: TicketDetailComponent },
      { path: 'ticket/add', component: AddTicketComponent },
      { path: 'ticket', component: TicketComponent },
=======
      { path: 'ticket', component: TicketComponent },
      { path: 'ticket/add', component: AddTicketComponent },
>>>>>>> bc2f7f2a933fda4757550676302c436a899eee86
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [TicketComponent, AddTicketComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
