import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewSingelFileComponent } from './view-singel-file.component';

describe('ViewSingelFileComponent', () => {
  let component: ViewSingelFileComponent;
  let fixture: ComponentFixture<ViewSingelFileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewSingelFileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewSingelFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
