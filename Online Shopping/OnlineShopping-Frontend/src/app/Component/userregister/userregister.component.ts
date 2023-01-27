import { Component } from '@angular/core';
import { User } from 'src/app/Model/user';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-userregister',
  templateUrl: './userregister.component.html',
  styleUrls: ['./userregister.component.css']
})
export class UserregisterComponent {

  user:User
  message = ''
  successMessage = ''
  constructor(public userService:UserService)
  {
    this.user = new User()
    
  }

  integreRegex = /^\d+$/

  emailRegex = /(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])/
  
  phoneRegex = /^[6-9]{1}[0-9]{9}$/;

 

  registerFn(){
    console.log(this.user)
    this.userService.AddUser(this.user).subscribe((res:any) => {
      this.successMessage = 'success, now login'
    },(err) => {
      this.message = 'already registered, login'
    })

  }
}
