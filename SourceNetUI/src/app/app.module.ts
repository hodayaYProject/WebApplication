import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SearchComponent } from './search/search.component';
import { SearchByNameComponent } from './search/SearchBy/search-by-name/search-by-name.component';
import { SearchByTagComponent } from './search/SearchBy/search-by-tag/search-by-tag.component';
import { SearchByDateComponent } from './search/SearchBy/search-by-date/search-by-date.component';
import { SearchByTypeComponent } from './search/SearchBy/search-by-type/search-by-type.component';
import { UploadComponent } from './upload/upload.component';
import { AddUserComponent } from './add-user/add-user.component';
import { ViewSingelFileComponent } from './search/view-singel-file/view-singel-file.component';

@NgModule({
  declarations: [
    AppComponent,
    SearchComponent,
    SearchByNameComponent,
    SearchByTagComponent,
    SearchByDateComponent,
    SearchByTypeComponent,
    UploadComponent,
    AddUserComponent,
    ViewSingelFileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
