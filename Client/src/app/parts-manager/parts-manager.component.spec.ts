import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PartsManagerComponent } from './parts-manager.component';

describe('PartsManagerComponent', () => {
  let component: PartsManagerComponent;
  let fixture: ComponentFixture<PartsManagerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PartsManagerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PartsManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
