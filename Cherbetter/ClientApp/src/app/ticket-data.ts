import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TicketItem } from './interfaces/ticket';

@Injectable()
export class MenuDataService {
  constructor(private http: HttpClient) { }

  getMenuItems() {
    return this.http.get<TicketItem[]>('/api/ticket');
  }
}
