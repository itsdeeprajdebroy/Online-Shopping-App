import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/service/cart.service';
import { ProductService } from 'src/app/service/product.service';
import { Product } from 'src/app/Model/product';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit{
  searchName:string = ''
  productByName:Product;
  nullProduct:Product
  public totalItem =0;
  constructor(private cartService : CartService, private productService:ProductService,public userService:UserService)
  {
    this.productByName = new Product()
    this.nullProduct = new Product()
    this.productByName = this.nullProduct
  }
 ngOnInit():void{
  this.cartService.getProducts()
  .subscribe(res=>{
    this.totalItem = res.length;
  })
 }

 //just to make empty productbyname
 Nullifier()
 {
  this.productByName = this.nullProduct
 }

 //to get productbyname
 Get()
 {
  this.productByName = this.nullProduct
   this.productService.GetProductByNames(this.searchName).subscribe(
     res =>{
       this.productByName = res
     }
   )
 }

}
