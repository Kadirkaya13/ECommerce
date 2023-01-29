import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';

@Component({
  selector: 'app-pager',
  templateUrl: './pager.component.html',
  styleUrls: ['./pager.component.css']
})
export class PagerComponent implements OnInit {
   
  @Input() totalCount!:number; 
  @Input() pageSize!:number; 
  @Input() pageNumber!:number; 
  @Output() pageChanged = new EventEmitter<PageChangedEvent>();


   constructor() {
    
   }
  
  ngOnInit(): void {
    
  }
  
  onPagerChanged(event : PageChangedEvent){
    this.pageChanged.emit(event);
  }
  

}
