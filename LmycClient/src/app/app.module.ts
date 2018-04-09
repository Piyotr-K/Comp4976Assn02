import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';
import { AppComponent } from './app.component';
import { BoatsComponent } from './boats/boats.component';
import {BoatsService} from './service/boats.service';

@NgModule({
  declarations: [
    AppComponent,
    BoatsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [
    BoatsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
