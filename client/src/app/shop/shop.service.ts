import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/IBrand';
import { IPagination } from '../shared/models/IPagination';
import { IProductType } from '../shared/models/IProductType';
import {map} from "rxjs/operators"

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  baseUrl = "https://localhost:44343/api/";
  constructor(private http: HttpClient) { }

  getProduct(brandId? : number,typeId? : number,sort? : string){
    let params = new HttpParams();
    if (brandId) {
      params = params.append("brandId",brandId.toString())
    }
    if (typeId) {
      params = params.append("typeId",typeId.toString())
    }
    if (sort) {
      params = params.append("sort",sort);
    }
    return this.http.get<IPagination>(this.baseUrl + "Products",{observe : "body",params})
    .pipe(
      map(response =>{
        return response
      })
    );
  }

  getBrand(){
    return this.http.get<IBrand[]>(this.baseUrl + "Brands")
  }

  getProductType(){
    return this.http.get<IProductType[]>(this.baseUrl + "ProductTypes")
  }

}
