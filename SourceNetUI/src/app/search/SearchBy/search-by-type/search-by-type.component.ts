import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-by-type',
  templateUrl: './search-by-type.component.html',
  styleUrls: ['./search-by-type.component.css']
})
export class SearchByTypeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  @Output() removeSearchByType: EventEmitter<any> = new EventEmitter();

  removeSearch(){
    this.removeSearchByType.emit(null);
  }

}
