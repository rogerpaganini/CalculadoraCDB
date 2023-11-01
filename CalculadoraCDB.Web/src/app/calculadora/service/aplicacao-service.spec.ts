import { HttpClientModule } from '@angular/common/http';
import { AplicacaoService } from './aplicacao-service';
import { TestBed } from '@angular/core/testing';  

describe('AplicacaoService', () => {
  let service : AplicacaoService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
    });
    service = TestBed.inject(AplicacaoService);
  });
  
  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
