import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Product } from '../Model/product';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  public cartItemList:any=[]
  public productlist = new BehaviorSubject<any>([])

  constructor() { }
  getProducts()
  {
    return this.productlist.asObservable();
  }
  setProduct(product:any)
  {
    this.cartItemList.push(...product);
    this.productlist.next(product);
  }
  addtoCart(product : Product)
  {
    this.cartItemList.push(product);
    this.productlist.next(this.cartItemList);
    this.getTotalPrice();
  }
  getTotalPrice():number
  {
    console.log(this.cartItemList)
    let grandTotal=0;
    for(let item of this.cartItemList)
    {
      grandTotal+=item.price;
    }
  
    console.log(grandTotal);
    return grandTotal;
  }
  removeCartItem(product:any)
  {
    let count = 0
    let index = 0
    while(true)
    {
      if(this.cartItemList[index].productId == product.productId)
      {
        this.cartItemList.splice(count,1)
      }
      count++
      index++
    }
    this.productlist.next(this.cartItemList);
  }
  removeAllCart()
  {
    this.cartItemList=[];
    this.productlist.next(this.cartItemList);
  }

}
