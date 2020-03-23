import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DatasharingService {
  private Source= new BehaviorSubject(false);
  Message=this.Source.asObservable();
  constructor() { }
  dataMessage(msg:boolean)
  {
    this.Source.next(msg)
  }
}
