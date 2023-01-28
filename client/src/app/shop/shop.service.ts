import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/IBrand';
import { IPagination } from '../shared/models/IPagination';
import { IProductType } from '../shared/models/IProductType';
import {map} from "rxjs/operators"
import { ShopParams } from '../shared/models/ShopParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  baseUrl = "https://localhost:44343/api/";
  constructor(private http: HttpClient) { }

  getProduct(shopParams : ShopParams){
    let params = new HttpParams();
    if (shopParams.brandId != 0) {
      params = params.append("brandId",shopParams.brandId.toString())
    }
    if (shopParams.typeId != 0) {
      params = params.append("typeId",shopParams.typeId.toString())
    }
      params = params.append("sort",shopParams.sort);
      params = params.append("pageIndex",shopParams.pageNumber.toString())
      params = params.append("pageIndex",shopParams.pageSize.toString())

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
