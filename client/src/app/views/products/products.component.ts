import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AttachSession } from 'protractor/built/driverProviders';
import { Product } from 'src/app/models/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: Array<Product> = [];
  showModalDelete: boolean = false;

  constructor(private _productService: ProductService, private _router: Router) { }

  ngOnInit(): void {
    this.getAllProducts();
  }

  async getAllProducts() {
    this.products = await this._productService.getAllProducts();

  }

  openProduct(id: number) {
    this._router.navigate([`/product/${id}`])
  }

  async deleteProduct(id: number) {
    const result = confirm('Do you really want delete this product?');
    if (result) {
      await this._productService.deleteProduct(id);
      this.getAllProducts();
    }
  }

}
