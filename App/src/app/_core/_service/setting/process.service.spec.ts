/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ProcessService } from './process.service';

describe('Service: Process', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProcessService]
    });
  });

  it('should ...', inject([ProcessService], (service: ProcessService) => {
    expect(service).toBeTruthy();
  }));
});
