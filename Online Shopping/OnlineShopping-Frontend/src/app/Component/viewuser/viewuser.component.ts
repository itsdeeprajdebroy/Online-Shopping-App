import { Component ,OnInit} from '@angular/core';
import { User } from 'src/app/Model/user';
import { UserService } from 'src/app/service/user.service';
@Component({
  selector: 'app-viewuser',
  templateUrl: './viewuser.component.html',
  styleUrls: ['./viewuser.component.css']
})
export class ViewuserComponent implements OnInit{
  user:User
  nullUser:User
  constructor(private userService:UserService)
  {
    this.nullUser = new User()
    this.user = new User()
  }
  ngOnInit(): void {
    this.userService.GetUser(+localStorage['userId']).subscribe(res => {
      this.user = res
    })
  }

  NullUser()
  {
    this.user = this.nullUser;
  }
}
