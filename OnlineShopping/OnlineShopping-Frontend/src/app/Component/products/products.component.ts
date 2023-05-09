import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/service/api.service';
import { CartService } from 'src/app/service/cart.service';
import { Product } from 'src/app/Model/product';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit{
  public productlist:any = [];
  constructor(private api :ApiService,private cartService : CartService, public userService:UserService)
  {

  }
  ngOnInit(): void {
    this.api.getProduct()
    .subscribe(res=>
      {
        this.productlist=res;
        // this.productlist.array.forEach((a:any) => 
        // {
        //  Object.assign(a,{quantity:1,total:a.price}); 
        // });
      })
  }
addtocart(item:Product)
{
 this.cartService.addtoCart(item);
}

}
