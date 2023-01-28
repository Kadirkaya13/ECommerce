import { Component, OnInit } from '@angular/core';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { IBrand } from '../shared/models/IBrand';
import { IProduct } from '../shared/models/IProduct';
import { IProductType } from '../shared/models/IProductType';
import { ShopParams } from '../shared/models/ShopParams';
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
  shopParams = new ShopParams();
  sortOptions =[
    {name:"Alphabetical", value:"name"},
    {name:"Price : Low to High", value:"priceAsc"},
    {name:"Price : High to Low", value:"priceDesc"}
  ]

  constructor(private shopService : ShopService){}

  ngOnInit(): void {
    this.getProduct();
    this.getBrand();
    this.getProductType();
  }

  getProduct(){
    this.shopService.getProduct(this.shopParams).subscribe(response=>{
        this.products = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.shopParams.totalCount = response.count;
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
    this.shopParams.brandId = brandId
    this.getProduct();
  }
  onTypeSelected(typeId:number){
    this.shopParams.typeId = typeId
    this.getProduct();
  }
  onSortSelected(sort:string){
    this.shopParams.sort = sort;
    this.getProduct();
  }

  onPageChanged(event : PageChangedEvent){
    this.shopParams.pageNumber = event.page;
    this.getProduct();
  }

  getValue(event: Event): string {
    return (event.target as HTMLInputElement).value;
  }
}
