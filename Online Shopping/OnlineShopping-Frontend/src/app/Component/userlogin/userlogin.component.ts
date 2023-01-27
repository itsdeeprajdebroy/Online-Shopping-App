import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Logindetails } from 'src/app/Model/logindetails';
import { User } from 'src/app/Model/user';
import { UserService } from 'src/app/service/user.service';
@Component({
  selector: 'app-userlogin',
  templateUrl: './userlogin.component.html',
  styleUrls: ['./userlogin.component.css']
})
export class UserloginComponent {
message = ''
obj:Logindetails
constructor(private userService:UserService,public router: Router)
{
  this.obj = new Logindetails()

}

Validate()
{
  this.userService.Login(this.obj).subscribe((res:any) => {
    if(res > 0)
    {
      this.message = "successful login"
      this.router.navigateByUrl('home');
      let textId = res.toString();
      this.userService.setUser(textId)
    }
  },(err) => {
    this.message = 'enter valid details'
  })
}
}
