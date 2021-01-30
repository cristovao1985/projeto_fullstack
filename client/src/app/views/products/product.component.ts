import { Route } from '@angular/compiler/src/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  productId!: number;
  product: Product = new Product();

  constructor(private _productService: ProductService, private _activateRoute: ActivatedRoute, private _route: Router) { }

  ngOnInit(): void {

    // Busca um id de produto para validar e buscar
    this.productId = this._activateRoute.snapshot.params.id;
    if (this.productId > 0) {
      this.getProductByID();
    }

  }

  async getProductByID() {
    // buscando produto por id
    this.product = await this._productService.getProductByID(this.productId);
  }

  async saveProduct() {

    switch (this.product.id) {
      case 0:
        // Chamar método de inserção
        await this._productService.insertProduct(this.product).then(result => {
          if (result.success) this._route.navigate(['/products']);
        });
        break;

      default:
        // Chamar método de update
        await this._productService.updateProduct(this.product).then(result => {
          if (result.success) this._route.navigate(['/products']);
        });
        break

    }


  }


}
