import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-view-singel-file',
  templateUrl: './view-singel-file.component.html',
  styleUrls: ['./view-singel-file.component.css']
})
export class ViewSingelFileComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  @Input() SingelFile: File;

}
