import { Injectable } from '@angular/core';
import {of} from 'rxjs/observable/of';
import { Boat } from '../Models/Boat';
import {Headers,Http,Response} from '@angular/http';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';

@Injectable()
export class BoatsService {

  constructor(private http: Http, ) { }
  private baseUrl = "https://a00996404asn02.azurewebsites.net/api/boatsapi";
  getBoats(): Promise<Boat[]> {
    return this.http.get(this.baseUrl)
      .toPromise()
      .then(response => response.json() as Boat[])
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error);
    return Promise.reject(error.message || error);
  }

}
