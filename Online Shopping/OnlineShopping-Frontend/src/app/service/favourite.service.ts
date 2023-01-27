import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Favourite } from '../Model/favourite';
import { Favouriteproduct } from '../Model/favouriteproduct';

@Injectable({
  providedIn: 'root'
})
export class FavouriteService {

  base_url = 'http://localhost:11836/api/Favourite/'

  constructor(public httpClient:HttpClient) { }

  AddFav(fav:Favourite):Observable<any>
  {
    return this.httpClient.post(this.base_url + 'AddFavourite',fav);
  }

  GetFav(id:number):Observable<Favouriteproduct[]>
  {
    return this.httpClient.get<Favouriteproduct[]>(this.base_url + 'GetAllFavouriteProducts/' + id)
  }

  Delete(pid:number,uid:number):Observable<any>
  {
    return this.httpClient.delete(this.base_url + 'DeleteFavouriteByProductId/' + pid + '/' + uid)
  }
}
