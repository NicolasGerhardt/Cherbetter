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
}
