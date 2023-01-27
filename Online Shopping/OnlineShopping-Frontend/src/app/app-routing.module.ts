import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './Component/products/products.component';
import { CartComponent } from './Component/cart/cart.component';
import { ProductComponent } from './Component/product/product.component';
import { UserloginComponent } from './Component/userlogin/userlogin.component';
import { UserregisterComponent } from './Component/userregister/userregister.component';
import { NavbarComponent } from './Component/Header/navbar/navbar.component';
import { WlistComponent } from './Component/wlist/wlist.component';
import { MyCartComponent } from './Component/my-cart/my-cart.component';
import { ViewuserComponent } from './Component/viewuser/viewuser.component';
import { EdituserComponent } from './Component/edituser/edituser.component';
const routes: Routes = [
  {path:'', redirectTo:'home',pathMatch:'full'},
  // {path:'products',component:ProductsComponent},
  // {path:'cart', component: CartComponent},
  {path:'product', component:ProductComponent},
  {path:'userlogin',component:UserloginComponent},
  {path:'userregister',component:UserregisterComponent},
  {path:'home',component:NavbarComponent},
  {path:'wishlist',component:WlistComponent},
  {path:'cart',component:MyCartComponent},
  {path:'user',component:ViewuserComponent},
  {path:'user/edit',component:EdituserComponent}
];

@NgModule({
 
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
