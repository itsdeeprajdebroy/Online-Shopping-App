import { Component , Input ,OnInit} from '@angular/core';
import { ProductService } from 'src/app/service/product.service';
import { Product } from 'src/app/Model/product';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/service/user.service';
import { Favourite } from 'src/app/Model/favourite';
import { FavouriteService } from 'src/app/service/favourite.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit{
@Input() product:Product

productById:Product
favourite:Favourite
message:string = ''
constructor(private productService:ProductService, private activatedRoute:ActivatedRoute , public userService:UserService,private fav:FavouriteService , public router:Router)
{
  
  this.product = new Product()
  this.productById = new Product()
  this.favourite = new Favourite()

}
  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe((params:any) => {
      let id = params.id;
      this.productService.GetProductById(id).subscribe((res:any) => {
        this.productById = res;
      })
    })
  }

  AddToFav(pId:number)
  {
    this.favourite.productId = pId
    this.favourite.userId = +localStorage['userId']
    this.fav.AddFav(this.favourite).subscribe(res => {
      
    },(err) => {
      this.message = 'already exists'
    })
  }


}
