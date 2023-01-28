import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'E-Commerce';
  

  constructor() {}

  ngOnInit(): void {
    // this.http.get('https://localhost:44343/api/products').subscribe(
    //   (response:any)=> {
    //     this.products = response.data;
    //   },
    //   (error) => {
    //     console.log(error);
    //   }
    // );
  }
}
