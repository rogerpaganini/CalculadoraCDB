import { TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { FormularioComponent } from './calculadora/formulario/formulario.component';
import { HttpClientTestingModule } from '@angular/common/http/testing'
import { ReactiveFormsModule } from '@angular/forms';

describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
    declarations: [AppComponent, FormularioComponent],   
    imports: [HttpClientTestingModule, ReactiveFormsModule], 
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'CalculadoraCDB'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('CalculadoraCDB');
  });

});
