import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  selectSearchBydate: boolean= false;
  selectSearchBytag: boolean=false;
  selectSearchByname: boolean=false;
  selectSearchBytype: boolean=false;

  ChangingValue(value:string){
    switch(value) { 
      case "1": { 
        this.selectSearchByname = true;
         break; 
      } 
      case "2": { 
         this.selectSearchBytag = true;
         break; 
      } 
      case "3": { 
        this.selectSearchBytype = true;
        break; 
      } 
      case "4": { 
        this.selectSearchBydate = true;
        break; 
      } 
      default: { 
        console.log("Invalid choice"); 
        break;              
     } 
    }
  }
  removeDate(){
    this.selectSearchBydate=false;
  }
  removeName(){
    this.selectSearchByname=false;
  }
  removeTag(){
    this.selectSearchBytag=false;
  }
  removeType(){
    this.selectSearchBytype=false;
  }
}
