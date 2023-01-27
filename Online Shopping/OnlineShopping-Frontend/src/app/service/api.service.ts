import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
 product_url:string = 'http://localhost:11836/api/Product/'
  constructor(private http : HttpClient) { }
  
  getProduct()
  {
    return this.http.get<any>(this.product_url +"GetAllProducts")
    .pipe(map((res:any)=>
    {return res;}))

	  
}
}