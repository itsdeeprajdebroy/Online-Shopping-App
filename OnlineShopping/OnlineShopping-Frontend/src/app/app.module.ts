import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Component/Header/navbar/navbar.component';
import {HttpClientModule} from '@angular/common/http';
import { ProductsComponent } from './Component/products/products.component';
import { CartComponent } from './Component/cart/cart.component';
import { FooterComponent } from './Component/footer/footer.component';
import { ProductComponent } from './Component/product/product.component';
import { UserloginComponent } from './Component/userlogin/userlogin.component';
import { UserregisterComponent } from './Component/userregister/userregister.component';
import { FormsModule } from '@angular/forms';
import { WlistComponent } from './Component/wlist/wlist.component';
import { MyCartComponent } from './Component/my-cart/my-cart.component';
import { OpenProductDirective } from './Directive/open-product.directive';
import { RouterModule } from '@angular/router';
import { ViewuserComponent } from './Component/viewuser/viewuser.component';
import { EdituserComponent } from './Component/edituser/edituser.component';
// import { WishlistComponent } from './Component/Wishlist/wishlist.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    
    ProductsComponent,
         CartComponent,
         FooterComponent,
         ProductComponent,
         UserloginComponent,
         UserregisterComponent,
         WlistComponent,
         MyCartComponent,
         OpenProductDirective,
         ViewuserComponent,
         EdituserComponent,
        //  WishlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
