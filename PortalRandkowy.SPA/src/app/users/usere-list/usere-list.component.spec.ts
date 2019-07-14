/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { UsereListComponent } from './usere-list.component';

describe('UsereListComponent', () => {
  let component: UsereListComponent;
  let fixture: ComponentFixture<UsereListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsereListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsereListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
