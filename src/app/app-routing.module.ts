import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomePageComponent } from './components/pages/home-page/home-page.component';
import { AboutPageComponent } from './components/pages/about-page/about-page.component';
import { LiteraturePageComponent } from './components/pages/literature-page/literature-page.component';
import { GamingPageComponent } from './components/pages/gaming-page/gaming-page.component';
import { PostComponent } from './components/post/post.component';
import { LoginComponent } from './components/login/login.component';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'login', component: LoginComponent },
  { path: 'literature', component: LiteraturePageComponent },
  { path: 'gaming', component: GamingPageComponent },
  { path: 'about', component: AboutPageComponent },
  { path: 'post/:id', component: PostComponent },
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
