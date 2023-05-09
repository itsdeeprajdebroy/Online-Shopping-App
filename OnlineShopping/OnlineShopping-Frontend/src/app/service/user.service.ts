import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Model/user';
import { Logindetails } from '../Model/logindetails';

@Injectable({
  providedIn: 'root'
})
export class UserService {
base_url:string = 'http://localhost:11836/api/User/'
  constructor(private httpClient:HttpClient) { }

  Login(item:Logindetails):Observable<any>
  {
    return this.httpClient.post(this.base_url + 'login',item);
  }

  setUser(id:string)
  {
    localStorage.setItem('userId',id);
  }

  isLoggedIn()
  {
    return localStorage.getItem('userId')? true : false
  }


  logOutUser()
  {
    localStorage.removeItem('userId')
  }

  GetUser(id?:number):Observable<User>
  {
    return this.httpClient.get<User>(this.base_url + 'GetUser/' + id)
  }

  EditUser(user:User):Observable<User>
  {
    return this.httpClient.put<User>(this.base_url + 'UpdateUser',user)
  }

  DeleteUser(id:number):Observable<any>
  {
    return this.httpClient.delete(this.base_url + 'DeleteUser/' + id)
  }

  AddUser(user:User):Observable<any>
  {
    return this.httpClient.post(this.base_url + 'RegisterUser',user)
  }

}
