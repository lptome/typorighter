import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { AboutPageComponent } from './components/about-page/about-page.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { LiteraturePageComponent } from './components/literature-page/literature-page.component';
import { GamingPageComponent } from './components/gaming-page/gaming-page.component';

@NgModule({
  declarations: [AppComponent, NavbarComponent, AboutPageComponent, HomePageComponent, LiteraturePageComponent, GamingPageComponent],
  imports: [BrowserModule, AppRoutingModule, NgbModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
