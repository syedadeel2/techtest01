import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs';
import { Product } from '../Models/IProduct';
import 'rxjs/add/operator/map';

@Injectable()
export class ProductService {
    constructor( private http: Http ) { }

    extractData( res: Response ) {

        return res.json();
    }

    getProducts(): Observable<Product[]> {
        return this.http.get( '/products/all' ).map( this.extractData );
    }

    getProduct( slug: string ): Observable<Product> {

        return this.http.get( '/api/product/' + slug ).map( this.extractData );

    }

}