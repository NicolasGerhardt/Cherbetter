import { Component } from '@angular/core';
import { TicketDataService } from '../ticket-data';
import { Ticket } from '../interfaces/ticket';

@Component({
    selector: 'app-ticket',
    templateUrl: './ticket.component.html',
    styleUrls: ['./ticket.component.scss']
})
/** ticket component*/
export class TicketComponent {
  /** ticket ctor */
  constructor(private ticketData: TicketDataService) { }

  tickets: Ticket[];

  ngOnInit() {
    this.ticketData.getTicketItems().subscribe(
      (data: Ticket[]) => {
        this.tickets = data;
      },
      error => console.error(error)
    );
  }


}
