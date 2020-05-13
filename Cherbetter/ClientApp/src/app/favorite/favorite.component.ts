import { Component } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ticket } from '../interfaces/ticket';
import { TicketDataService } from '../ticket-data';
import { ActivatedRoute } from '@angular/router';


@Component({
    selector: 'app-favorite',
    templateUrl: './favorite.component.html',
    styleUrls: ['./favorite.component.scss']
})
/** favorite component*/
export class FavoriteComponent {
    /** favorite ctor */

  email: string;
  tickets: Ticket[];

  constructor(private ticketData: TicketDataService, private route: ActivatedRoute) {

  }

  ngOnInit() {
    this.ticketData.getFavoritesByEmail().subscribe(
      (data: Ticket[]) => {
        this.tickets = data;
      },
      error => console.error(error)
    );
  }

}
