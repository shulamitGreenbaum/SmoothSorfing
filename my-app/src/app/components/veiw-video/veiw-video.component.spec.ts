import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VeiwVideoComponent } from './veiw-video.component';

describe('VeiwVideoComponent', () => {
  let component: VeiwVideoComponent;
  let fixture: ComponentFixture<VeiwVideoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VeiwVideoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VeiwVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
