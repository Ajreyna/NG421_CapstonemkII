import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RockerComponent } from './rocker.component';

describe('RockerComponent', () => {
  let component: RockerComponent;
  let fixture: ComponentFixture<RockerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RockerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RockerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
