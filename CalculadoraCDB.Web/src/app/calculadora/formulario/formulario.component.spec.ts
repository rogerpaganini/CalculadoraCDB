import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormularioComponent } from './formulario.component';
import { HttpClientModule } from '@angular/common/http';
import { AplicacaoService } from '../service/aplicacao-service';
import { ReactiveFormsModule } from '@angular/forms';

describe('FormularioComponent', () => {
  let component: FormularioComponent;
  let fixture: ComponentFixture<FormularioComponent>;

  beforeEach(async() => {
    await TestBed.configureTestingModule({
      imports: [HttpClientModule, ReactiveFormsModule],
      declarations: [FormularioComponent],  
      providers: [AplicacaoService] 
    }).compileComponents();
});

  it('should create', () => {
    fixture = TestBed.createComponent(FormularioComponent);
    component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });

});
