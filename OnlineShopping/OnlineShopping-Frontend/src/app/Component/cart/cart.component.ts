import { Component, OnInit ,Input} from '@angular/core';
import { Product } from 'src/app/Model/product';
import { CartService } from 'src/app/service/cart.service';
import { Favouriteproduct } from 'src/app/Model/favouriteproduct';
import { FavouriteService } from 'src/app/service/favourite.service';
import { Observable, interval, Subscription } from 'rxjs';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit{
  @Input() view: 'cart' | 'wishlist' | 'none'  = 'none'
  public products :Product[]=[];
  public wishProduct:Favouriteproduct[] = [];
  public grandTotal !: number;
  // private updateSubscription: Subscription;
  // pid:number = 0
  constructor(private cartservice : CartService,public fav:FavouriteService)
  {
    // this.updateSubscription = interval(100).subscribe((val) => {
    //   this.DeleteFavProduct(this.pid)
    // })
  }
  ngOnInit(): void {
    if(this.view == 'cart')
    {
      this.cartservice.getProducts()
      .subscribe(res=>
        {
          this.products=res;
          this.grandTotal=this.cartservice.getTotalPrice();
        })
    }
    if(this.view == 'wishlist')
    {
      this.fav.GetFav(+localStorage['userId']).subscribe(response => {
        this.wishProduct = response;
        console.log(response)
      })
    }
  }
  removeItem(item:any)
  {
    this.cartservice.removeCartItem(item);
  }
  emptycart(){
    this.cartservice.removeAllCart();
  }

  DeleteFavProduct(id:number)
  {
    this.fav.Delete(id,+localStorage['userId']).subscribe(res => {

    })
  }

  //for auto component refresh
  reloadCurrentComponent()
  {
    window.location.reload();
  }
}
