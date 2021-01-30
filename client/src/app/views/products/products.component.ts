import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: Array<Product> = [];
  constructor(private _productService: ProductService) { }

  ngOnInit(): void {
  }

  async getAllProducts() {
    this.products = await this._productService.getAllProducts();

  }

}
