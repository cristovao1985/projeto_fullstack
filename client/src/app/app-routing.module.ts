import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from "./views/products/products.component";
import { ProductComponent } from "./views/products/product.component"
import { LoginComponent } from "./views/login/login.component";
import { AppComponent } from './app.component';
import { RouterService as AuthGuardSerice } from "../app/guards/router.service"

const routes: Routes = [
  { path: 'home', component: AppComponent, canActivate: [AuthGuardSerice] },
  { path: 'products', component: ProductsComponent, canActivate: [AuthGuardSerice] },
  { path: 'product', component: ProductComponent, canActivate: [AuthGuardSerice] },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
