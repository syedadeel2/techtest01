import { Component } from '@angular/core';
import { ProductListComponent } from './productList.component';

@Component({
  selector: 'my-app',
  template: `<h1>Welcome To {{name}}</h1> <br /> <product-list>Loading Products</product-list>`,
})
export class AppComponent { name = 'True Alliance SPA Site'; }
