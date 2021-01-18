import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PostService } from 'src/app/services/post.service';
import { Post } from '../../models/post.model';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss'],
})
export class PostComponent implements OnInit {
  id: number = NaN;
  post: Post = {} as Post;

  constructor(
    private route: ActivatedRoute,
    private postService: PostService
  ) {}

  ngOnInit(): void {
    let id = this.route.snapshot.paramMap.get('id');
    if (id != null) {
      this.id = +id;
      this.postService.getPost(this.id).subscribe((data) => {
        console.log(data);
        this.post = new Post(
          this.id,
          data.title,
          data.body,
          data.summary,
          data.coverImageSource,
          new Date(data.datePublished)
        );
      });
      console.log(this.post);
    }
  }
}
