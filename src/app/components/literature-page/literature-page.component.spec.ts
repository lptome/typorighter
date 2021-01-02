import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LiteraturePageComponent } from './literature-page.component';

describe('LiteraturePageComponent', () => {
  let component: LiteraturePageComponent;
  let fixture: ComponentFixture<LiteraturePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LiteraturePageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LiteraturePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
