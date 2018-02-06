import { Component, Input, Injectable, OnInit } from '@angular/core';
import { ProductService } from '../app/Services/products.service';
import { Product } from '../app/Models/IProduct';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component( {
    selector: 'product',
    template: `
<div class="row">
<button type="button" (click)="this.router.navigate(['/products'])">Back to Catalog</button>
    <div class="product-detail">
        <div class="col-xs-4 item-photo">
            <img style="max-width:100%;" src="{{product.ImageUrl}}" />
        </div>
        <div class="col-xs-5" style="border:0px solid gray">
            <h3>{{product.Name}}</h3>

            <h6 class="title-price"><small>Price</small></h6>
            <h3 style="margin-top:0px;">US$ {{product.Price}}</h3>



            <div class="section" style="padding-bottom:20px;">
                <h6 class="title-attr"><small>Qty</small></h6>
                <div>
                    <div class="btn-minus"><span class="glyphicon glyphicon-minus"></span></div>
                    <input value="1" />
                    <div class="btn-plus"><span class="glyphicon glyphicon-plus"></span></div>
                </div>
            </div>


            <div class="section" style="padding-bottom:20px;">
                <button class="btn btn-success" type="button" onclick="alert( 'This is a button without any functionality' );"><span style="margin-right:20px" class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span>Add To Cart</button>
            </div>
        </div>

        <div class="col-xs-9">
            <ul class="menu-items">
                <li class="active">Description</li>
            </ul>
            <div style="width:100%;border-top:1px solid silver">
                <p style="padding:15px;">
                    <small>
                        {{product.Description}}
                    </small>
                </p>
            </div>
        </div>
    </div>
</div>
`,
    providers: [ProductService]
} )

export class ProductComponent implements OnInit {
    product: Product;

    constructor( private service: ProductService, private route: ActivatedRoute, private router: Router ) { }

    ngOnInit(): void {
        let slug = this.route.snapshot.paramMap.get( 'slug' );
        this.service.getProduct( slug ).subscribe( product => {
            this.product = product;
        } );
    }
}
