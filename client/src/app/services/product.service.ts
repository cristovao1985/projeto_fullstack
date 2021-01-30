
import { Injectable, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private baseUrl = "http://localhost:5000/api/";


  //public showMenuEmitter: EventEmitter<boolean> = new EventEmitter<boolean>();
  constructor(private router: Router) { }

  async getAllProducts() {

    await fetch(`${this.baseUrl}/login`, {
      method: "GET",

    }).then(async res => {
      const result = await res.json();


    }).catch(erro => {


    })


  }
}
