import { Component, OnInit } from '@angular/core';
import { Post } from '../../models/Post';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  posts: Post[] = [
    {
      title: 'Elephants are REALLY heavy',
      summary:
        'Did you know that elephants are the only animal that cannot jump?',
      body:
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi mattis tellus nec pretium iaculis. Sed at blandit nisi, at fringilla ligula. Phasellus consectetur, eros in posuere porta, ipsum risus suscipit sem, sit amet convallis leo ex ac tortor. In nibh ex, aliquet id congue ut, fermentum ut arcu. Praesent ornare nibh enim. Praesent tincidunt elit et lorem aliquet, et bibendum elit vehicula. Donec feugiat dolor et mauris dapibus, eget semper eros euismod. Nullam orci felis, vehicula sit amet tincidunt sit amet, accumsan eu leo. Nunc a lacinia nisi, eu egestas nulla.',
      coverImgSrc:
        'https://c402277.ssl.cf1.rackcdn.com/photos/18366/images/carousel_small/Asian_Elephants_WW252891.jpg?1576701543',
      datePublished: new Date('06-01-2021'),
      tags: ['Animals', 'Hello', 'World'],
    },
    {
      title: 'Drop bears may be real after all',
      summary:
        'Did you know that Koala fingerprints are so similar to human fingerprints that the two are often confused at crime scenes?',
      body:
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi mattis tellus nec pretium iaculis. Sed at blandit nisi, at fringilla ligula. Phasellus consectetur, eros in posuere porta, ipsum risus suscipit sem, sit amet convallis leo ex ac tortor. In nibh ex, aliquet id congue ut, fermentum ut arcu. Praesent ornare nibh enim. Praesent tincidunt elit et lorem aliquet, et bibendum elit vehicula. Donec feugiat dolor et mauris dapibus, eget semper eros euismod. Nullam orci felis, vehicula sit amet tincidunt sit amet, accumsan eu leo. Nunc a lacinia nisi, eu egestas nulla.',
      coverImgSrc:
        'https://www.australiangeographic.com.au/wp-content/uploads/2018/06/drop-bear.jpg',
      datePublished: new Date('06-01-2021'),
      tags: ['Forensics', 'Hello', 'World'],
    },
    {
      title: 'Drop bears may be real after all',
      summary:
        'Did you know that Koala fingerprints are so similar to human fingerprints that the two are often confused at crime scenes?',
      body:
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi mattis tellus nec pretium iaculis. Sed at blandit nisi, at fringilla ligula. Phasellus consectetur, eros in posuere porta, ipsum risus suscipit sem, sit amet convallis leo ex ac tortor. In nibh ex, aliquet id congue ut, fermentum ut arcu. Praesent ornare nibh enim. Praesent tincidunt elit et lorem aliquet, et bibendum elit vehicula. Donec feugiat dolor et mauris dapibus, eget semper eros euismod. Nullam orci felis, vehicula sit amet tincidunt sit amet, accumsan eu leo. Nunc a lacinia nisi, eu egestas nulla.',
      coverImgSrc:
        'https://www.australiangeographic.com.au/wp-content/uploads/2018/06/drop-bear.jpg',
      datePublished: new Date('06-01-2021'),
      tags: ['Test', 'Hello', 'World'],
    },
    {
      title: 'Drop bears may be real after all',
      summary:
        'Did you know that Koala fingerprints are so similar to human fingerprints, they are often confused at crime scenes?',
      body:
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi mattis tellus nec pretium iaculis. Sed at blandit nisi, at fringilla ligula. Phasellus consectetur, eros in posuere porta, ipsum risus suscipit sem, sit amet convallis leo ex ac tortor. In nibh ex, aliquet id congue ut, fermentum ut arcu. Praesent ornare nibh enim. Praesent tincidunt elit et lorem aliquet, et bibendum elit vehicula. Donec feugiat dolor et mauris dapibus, eget semper eros euismod. Nullam orci felis, vehicula sit amet tincidunt sit amet, accumsan eu leo. Nunc a lacinia nisi, eu egestas nulla.',
      coverImgSrc:
        'https://www.australiangeographic.com.au/wp-content/uploads/2018/06/drop-bear.jpg',
      datePublished: new Date('06-01-2021'),
      tags: ['Test', 'Hello', 'World'],
    },
  ];
  constructor() {}

  ngOnInit(): void {}
}
