import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ticket } from './interfaces/ticket';
import { Favorite } from './interfaces/favorite';

@Injectable({ providedIn: 'root' })
export class TicketDataService {
  constructor(private http: HttpClient) { }

  getTicketItems() {
    return this.http.get<Ticket[]>('/api/ticket');
  }
  getTicketByID(ID:number) {
    return this.http.get<Ticket>(`/api/ticket/${ID}`)
  }

  getFavoritesByTicketID(TicketID: number) {
    return this.http.get<Favorite[]>(`/api/favorites/${TicketID}`);
  }

  addFavorite(favorite: Favorite) {
    return this.http.post<Favorite>('/api/favorites', favorite);
  }

  addTicket(newTicket: Ticket) {
    return this.http.post<Ticket>('/api/ticket', newTicket);
  }

  resolveTicket(ticket: Ticket) {
    return this.http.put<Ticket>(`/api/ticket/resolve/${ticket.TID}`, ticket);
  }

}
