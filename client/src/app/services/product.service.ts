
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../models/Product';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private baseUrl = "http://localhost:5000/api";

  constructor(private router: Router) { }

  async getAllProducts(): Promise<Array<Product>> {

    return await fetch(`${this.baseUrl}/product`, {
      method: "GET",
    }).then(res => {
      return res.json();
    }).catch(erro => {
      return null
    })
  }

  async insertProduct(product: Product): Promise<any> {
    return await fetch(`${this.baseUrl}/product`, {
      method: "POST",
      body: JSON.stringify(product)
    }).then(res => {
      return res.json();
    }).catch(erro => {
      return erro
    })
  }
}
