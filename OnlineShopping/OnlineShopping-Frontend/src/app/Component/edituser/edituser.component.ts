import { Component ,Input} from '@angular/core';
import { User } from 'src/app/Model/user';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-edituser',
  templateUrl: './edituser.component.html',
  styleUrls: ['./edituser.component.css']
})
export class EdituserComponent {
  user:User
  error:any;
  
  constructor(private userService:UserService)
  {
    this.user = new User()
    this.userService.GetUser(+localStorage['userId']).subscribe(res => {
      this.user = res
    })
  }

  Edit()
  {
    this.userService.EditUser(this.user).subscribe(res => {
      this.user = res
    },(err) =>
    {
      this.error = err.message
    }
    )
  }

  Delete()
  {
    this.userService.DeleteUser(+localStorage['userId']).subscribe(res => {
      
    })
    this.userService.logOutUser();
  }
}
