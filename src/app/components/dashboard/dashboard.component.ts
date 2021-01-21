import { Component, OnInit } from '@angular/core';
import { PostService } from 'src/app/services/post.service';
import { Post } from '../../models/post.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  latestPosts: Post[] = [];

  //Show or hide spinner
  showSpinner: boolean = true;

  constructor(private postService: PostService) {}

  ngOnInit(): void {
    this.postService.getLatestPosts().subscribe((data) => {
      data.forEach((post: any) => {
        let tags: string[] = [];

        if (post.categories != null) {
          post.categories.forEach((cat: any) => {
            tags.push(cat.name);
          });
        }

        this.latestPosts.push(
          new Post(
            post.id,
            post.title,
            post.body,
            post.summary,
            post.coverImageSource,
            new Date(post.datePublished),
            tags
          )
        );
      });
      this.showSpinner = false;
    });
  }
}
