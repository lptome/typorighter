import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page.component';
import { AboutPageComponent } from './components/about-page/about-page.component';
import { LiteraturePageComponent } from './components/literature-page/literature-page.component';
import { GamingPageComponent } from './components/gaming-page/gaming-page.component';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'literature', component: LiteraturePageComponent },
  { path: 'gaming', component: GamingPageComponent },
  { path: 'about', component: AboutPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
export const routingComponents = [
  HomePageComponent,
  LiteraturePageComponent,
  GamingPageComponent,
  AboutPageComponent,
];
