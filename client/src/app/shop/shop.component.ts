import { Component, OnInit } from '@angular/core';
import { IBrand } from '../shared/models/IBrand';
import { IProduct } from '../shared/models/IProduct';
import { IProductType } from '../shared/models/IProductType';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit{

  products: IProduct[]=[];
  brands: IBrand[]=[];
  productTypes: IProductType[]=[];
  brandIdSelected? : number;
  typeIdSelected? : number;

  constructor(private shopService : ShopService){}

  ngOnInit(): void {
    this.getProduct();
    this.getBrand();
    this.getProductType();
  }

  getProduct(){
    this.shopService.getProduct(this.brandIdSelected,this.typeIdSelected).subscribe(response=>{
        this.products = response.data;
    },err =>{
      console.log(err);
    });
  }

  getBrand(){
    this.shopService.getBrand().subscribe(response=>{
      var firstItem = {id:0,name:"All"}
      this.brands = [firstItem,...response];
    },err =>{
      console.log(err);
    });
  }

  getProductType(){
    this.shopService.getProductType().subscribe(response=>{
      var firstItem = {id:0,name:"All"}
      this.productTypes = [firstItem,...response];
    },err =>{
      console.log(err);
    });
  }

  onBrandSelected(brandId:number){
    this.brandIdSelected = brandId
    this.getProduct();
  }
  onTypeSelected(typeId:number){
    this.typeIdSelected = typeId
    this.getProduct();
  }
}
