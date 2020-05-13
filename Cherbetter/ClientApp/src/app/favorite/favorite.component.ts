import { Component } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TicketDataService } from '../ticket-data';
import { ActivatedRoute } from '@angular/router';
import { Favorite } from '../interfaces/favorite';


@Component({
    selector: 'app-favorite',
    templateUrl: './favorite.component.html',
    styleUrls: ['./favorite.component.scss']
})
/** favorite component*/
export class FavoriteComponent {
    /** favorite ctor */
  id: number;
  favorites: Favorite[];

  constructor(private ticketData: TicketDataService, private route: ActivatedRoute) {

  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
    });

    this.ticketData.getFavoritesByTicketID(this.id).subscribe(
      (data: Favorite[]) => {
        this.favorites = data;
      },
      error => console.error(error)
    );

  }

}
