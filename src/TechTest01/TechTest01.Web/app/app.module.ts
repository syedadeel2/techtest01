import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; 

import { AppComponent } from './app.component';
import { ProductListComponent } from './productList.component';

@NgModule( {
    imports: [BrowserModule, HttpClientModule],
    declarations: [AppComponent, ProductListComponent],
    bootstrap: [AppComponent]
} )
export class AppModule { }
