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
  viewSingelFile:boolean=false;
  SelectedFile:File;

  resource:File[]=[
    {
    resourceCode: 1,
    resourceName:'aaa.jpg',
    filePath:'sdfsdfetr34rc34t4c',
    version:'ewfwrferfe',
    authorName:'sfdsfsd',
    date:new Date('2014-04-03'),
    resourcePermission:2
  },
  {
    resourceCode: 2,
    resourceName:'bbb.pdf',
    filePath:'sdfsdfetr34rc34t4c',
    version:'ewfwrferfe',
    authorName:'sfdsfsd',
    date:new Date('2014-04-03'),
    resourcePermission:3
  },
  {
    resourceCode: 3,
    resourceName:'aaa.docx',
    filePath:'s4t4c',
    version:'ewfwrferfe',
    authorName:'dfsdfsd',
    date:new Date('2014-04-03'),
    resourcePermission:1
  },
  {
    resourceCode: 4,
    resourceName:'ccc.nyy',
    filePath:'sdfsdfetr34rc34t4c',
    version:'ewfwrferfe',
    authorName:'sfdsfsd',
    date:new Date('2014-04-03'),
    resourcePermission:2
  }
];

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

  showFiles(){

  }
  singelFile(res:any){
    this.viewSingelFile=true;
    this.SelectedFile=res;
    
  }


}
export class File{
  resourceCode: number;
  resourceName:string;
  filePath:string;
  version:string;
  authorName:string;
  date:Date;
  resourcePermission:number;
}
