export class Post {
  id: number = 0;
  title: string = '';
  body: string = '';
  summary: string = '';
  coverImageSource: string = '';
  datePublished: Date = new Date();
  tags: string[] = [];

  constructor(
    id: number,
    title: string,
    body: string,
    summary: string,
    coverImageSrc: string,
    datePublished: Date,
    tags: string[]
  ) {
    this.id = id;
    this.title = title;
    this.body = body;
    this.summary = summary;
    this.coverImageSource = coverImageSrc;
    this.datePublished = datePublished;
    this.tags = tags;
  }
}
