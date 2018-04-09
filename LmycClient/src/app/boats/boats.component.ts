import {BoatsService} from './../service/boats.service';

import { Component, inject } from '@angular/core';
import {Boat} from '../Models/Boat';

@Component({
  selector: 'boats-list',
  templateUrl: './boats.component.html',
  styleUrls: ['./boats.component.css']
})
export class BoatsComponent implements OnInit {
  public boats: Boat[];


  constructor(private boatsService: BoatsService) {}
  ngOnInit() {
    this.getBoats();
  }

  getBoats(): void {
   this.boatsService.getBoats()
     .then(boats => this.boats = boats);
  }
}
