import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-by-tag',
  templateUrl: './search-by-tag.component.html',
  styleUrls: ['./search-by-tag.component.css']
})
export class SearchByTagComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Output() removeSearchByTag: EventEmitter<any> = new EventEmitter();

  removeSearch(){
    this.removeSearchByTag.emit(null);
  }
}
