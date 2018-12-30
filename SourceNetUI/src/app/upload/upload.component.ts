import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }


  options = [
    { name: "צפיה", value: 1 },
    { name: "הורדה", value: 2 },
    { name: "עריכה", value: 2 }
  ]

  selectPermission(value:string){
  }

}
