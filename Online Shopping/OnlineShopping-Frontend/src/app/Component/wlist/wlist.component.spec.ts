import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WlistComponent } from './wlist.component';

describe('WlistComponent', () => {
  let component: WlistComponent;
  let fixture: ComponentFixture<WlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WlistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
