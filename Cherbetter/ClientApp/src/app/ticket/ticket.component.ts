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
  constructor(private menuData: TicketDataService,
    private cartData: TicketDataService) { }

  tikets: TicketItem[];

  ngOnInit() {
    this.ticketData.getTickets().subscribe(
      (data: TicketItem[]) => {
        this.tickets = data;
      },
      error => console.error(error)
    );
  }


}
