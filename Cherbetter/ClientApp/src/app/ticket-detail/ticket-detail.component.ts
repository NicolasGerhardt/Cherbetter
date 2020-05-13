import { Component, OnInit, Input } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ticket } from '../interfaces/ticket';
import { TicketDataService } from '../ticket-data';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-ticket-detail',
    templateUrl: './ticket-detail.component.html',
    styleUrls: ['./ticket-detail.component.scss']
})
/** ticket-detail component*/
export class TicketDetailComponent {

  id: number;
  ticket: Ticket;

    /** ticket-detail ctor */
  constructor(private ticketData: TicketDataService, private route: ActivatedRoute) {

  }

  ngOnInit(): void {

    this.route.params.subscribe(params => {
      this.id = +params['id'];
    });

    this.ticketData.getTicketByID(this.id).subscribe(
      (data: Ticket) => this.ticket = { ...data },
      error => console.error(error)
    );
    console.log(this.ticket);


  }

  AddResolution() {
    this.ticketData.resolveTicket(this.ticket).subscribe();
  }


}
