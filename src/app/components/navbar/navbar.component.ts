import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent implements OnInit {
  @Input()
  isLoggedIn: boolean = false;

  constructor(private router: Router) {}

  ngOnInit(): void {}

  testFunction() {
    console.log(this.isLoggedIn);
  }

  logOut() {
    localStorage.removeItem('jwt');
    this.router.navigate(['login']);
  }
}
