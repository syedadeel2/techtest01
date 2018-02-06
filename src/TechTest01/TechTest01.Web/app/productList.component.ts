import { Component, Input, Injectable, OnInit } from '@angular/core';
import { ProductService } from '../app/Services/products.service';
import { Product } from '../app/Models/IProduct';
import { ProductComponent } from './product.component';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component( {
    selector: 'product-list',
    template: `
<h2>Latest Products</h2>
<div *ngFor="let product of productList" class="col-xs-6 col-md-4">
    <div class="product tumbnail thumbnail-3">
        <a (click)="navigate(product.Slug)"><img src="{{product.ImageUrl}}" alt=""></a>
        <div class="caption">
            <h6><a (click)="navigate(product.Slug)">{{product.Name}}</a></h6><span class="price">
            </span><span class="price sale">$ {{product.Price}}</span>
        </div>
    </div>
</div>
`,
    providers: [ProductService]
} )

export class ProductListComponent implements OnInit {
    productList: any;

    constructor( private service: ProductService, private route: ActivatedRoute, private router: Router ) { }

    ngOnInit(): void {

        this.service.getProducts().subscribe( products => {
            this.productList = products;
        } );

    }

    navigate( slug: string ): void {
        this.router.navigate( ['/product/' + slug] );
    }
}
