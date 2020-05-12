import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TicketItem } from './interfaces/ticket';

@Injectable()
export class TicketDataService {
  constructor(private http: HttpClient) { }

  getTicketItems() {
    return this.http.get<TicketItem[]>('/api/ticket');
  }
}
