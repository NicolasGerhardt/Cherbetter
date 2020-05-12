import { Component } from '@angular/core';
import { TicketDataService } from '../ticket-data';
import { TicketItem } from '../interfaces/ticket';

@Component({
    selector: 'app-ticket',
    templateUrl: './ticket.component.html',
    styleUrls: ['./ticket.component.scss']
})
/** ticket component*/
export class TicketComponent {
  /** ticket ctor */
  constructor(private ticketData: TicketDataService) { }

  tickets: TicketItem[];

  ngOnInit() {
    this.ticketData.getTicketItems().subscribe(
      (data: TicketItem[]) => {
        this.tickets = data;
      },
      error => console.error(error)
    );
  }


}
