import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-by-date',
  templateUrl: './search-by-date.component.html',
  styleUrls: ['./search-by-date.component.css']
})
export class SearchByDateComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Output() removeSearchByDate: EventEmitter<any> = new EventEmitter();

  removeSearch(){
    this.removeSearchByDate.emit(null);
  }
}
