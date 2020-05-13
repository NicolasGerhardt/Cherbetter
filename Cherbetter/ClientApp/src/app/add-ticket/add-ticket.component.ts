import { Component } from '@angular/core';
import { TicketDataService } from '../ticket-data';
import { Ticket } from '../interfaces/ticket';

@Component({
    selector: 'app-add-ticket',
    templateUrl: './add-ticket.component.html',
    styleUrls: ['./add-ticket.component.scss']
})
/** add-ticket component*/
export class AddTicketComponent {
  title: string;
  description: string;

/** add-ticket ctor */
    constructor(private ticketData: TicketDataService) {

  }

  submitTicket() {
    if (this.title == '' || this.description == '') {
      return;
    }

    let newTicket: Ticket = {
      TID : 0,
      Title: this.title,
      TDescription: this.description,
      TStatus: '0',
      Resolution: '',
    }

    this.ticketData.addTicket(newTicket).subscribe();
  }
}
