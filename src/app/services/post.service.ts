import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Post } from '../models/post.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PostService {
  readonly rootUrl = 'https://localhost:44307/api/BlogPosts';

  constructor(private http: HttpClient) {}

  //Fetch the latest 8 posts from the API
  getLatestPosts(): Observable<any> {
    return this.http.get(this.rootUrl + '/latest');
  }

  //Fetch Post by ID
  getPost(id: number): Observable<any> {
    return this.http.get<Post>(this.rootUrl + `/${id}`);
  }
}
