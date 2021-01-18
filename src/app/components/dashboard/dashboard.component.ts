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

  constructor(private postService: PostService) {}

  ngOnInit(): void {
    this.postService.getLatestPosts().subscribe((data) => {
      data.forEach((post: any) => {
        this.latestPosts.push(
          new Post(
            post.id,
            post.title,
            post.body,
            post.summary,
            post.coverImageSource,
            new Date(post.datePublished)
          )
        );
      });
    });
  }
}
