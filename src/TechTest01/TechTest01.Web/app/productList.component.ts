import { Component, Input, Injectable, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component( {
    selector: 'product-list',
    template: `
<div ngFor="let product of products" class="col-xs-6 col-md-4">
    <div class="product tumbnail thumbnail-3">
        <a href="{{product.Slug}}"><img src="{{product.ImageUrl}}" alt=""></a>
        <div class="caption">
            <h6><a href="{{product.Slug}}">{{product.Name}}</a></h6><span class="price">
            </span><span class="price sale">$ {{product.Price}}</span>
        </div>
    </div>
</div>
`,
} )

@Injectable()
export class ProductListComponent implements OnInit  {
    private productList: Array<object>;
    private httpObj: HttpClient;

    ngOnInit(): void {

        this.httpObj.get( "/products/all" ).subscribe( data => {
            var index: any;
            for ( index in data ) {
                this.productList.push( data[index] );
            }
        } );

    }


    constructor( http: HttpClient ) {
        this.httpObj = http;
    }

    products = () => this.productList;
}
