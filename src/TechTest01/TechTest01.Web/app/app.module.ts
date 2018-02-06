import { NgModule, ModuleWithProviders } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ProductListComponent } from './productList.component';
import { ProductComponent } from './product.component';
import { ProductService } from '../app/Services/products.service';

export const routes: Routes = [
    { path: 'products', component: ProductListComponent },
    { path: 'product/:slug', component: ProductComponent }
];


@NgModule( {
    imports: [BrowserModule, HttpClientModule, HttpModule, RouterModule.forRoot( routes, { useHash: true } )],
    declarations: [AppComponent, ProductListComponent, ProductComponent],
    bootstrap: [AppComponent],
    providers: [ProductService]
} )
export class AppModule { }
