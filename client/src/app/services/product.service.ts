
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
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(product)
    }).then(res => {
      return res.json();
    }).catch(erro => {
      return erro
    })
  }

  async getProductByID(id: number): Promise<Product> {
    return await fetch(`${this.baseUrl}/product/${id}`, {
      method: "GET",
    }).then(res => {
      return res.json();
    }).catch(erro => {
      return erro
    })
  }

  async updateProduct(product: Product): Promise<any> {
    return await fetch(`${this.baseUrl}/product`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(product)
    }).then(res => {
      return res.json();
    }).catch(erro => {
      return erro
    })
  }
  async deleteProduct(id: number): Promise<any> {
    return await fetch(`${this.baseUrl}/product/${id}`, {
      method: "DELETE",
      headers: { "Content-Type": "application/json" },

    }).then(res => {
      return res.json();
    }).catch(erro => {
      return erro
    })
  }
}
