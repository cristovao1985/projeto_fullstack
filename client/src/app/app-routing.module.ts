import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from "./views/products/products.component";
import { LoginComponent } from "./views/login/login.component";
import { AppComponent } from './app.component';
import { RouterService as AuthGaurdSerice } from "../app/guards/router.service"

const routes: Routes = [
  { path: 'home', component: AppComponent, canActivate: [AuthGaurdSerice] },
  { path: 'products', component: ProductsComponent, canActivate: [AuthGaurdSerice] },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
