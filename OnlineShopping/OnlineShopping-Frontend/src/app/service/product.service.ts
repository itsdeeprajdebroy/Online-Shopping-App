import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Model/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(public httpClient:HttpClient) { }

  product_url:string = 'http://localhost:11836/api/Product/'

  GetProductByNames(name?:string):Observable<Product>
  {
    return this.httpClient.get<Product>(this.product_url+'GetProductByName/'+name);
  }

  GetProductById(id?:number):Observable<Product>
  {
    return this.httpClient.get<Product>(this.product_url+'GetProductByProductId/'+id);
  }

}
