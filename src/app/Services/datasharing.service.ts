import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DatasharingService {
  private Source= new BehaviorSubject('row view');
  Message=this.Source.asObservable();
  private Sources= new BehaviorSubject(false);
  Messageacc=this.Source.asObservable();
  private notesource=new BehaviorSubject("");
  Note=this.notesource.asObservable();
  private collaboratorSource=new BehaviorSubject("");
  collaborator=this.collaboratorSource.asObservable();
  private searchSource = new BehaviorSubject('');
  findMessage = this.searchSource.asObservable();
  private card = new BehaviorSubject(false);
  currentCard = this.card.asObservable();
  private labelSource = new BehaviorSubject(false);
  currentLabel = this.labelSource.asObservable();


  constructor() { }
  dataMessage(msg:string)
  {
    this.Source.next(msg)
  }
  upmessage(msgg:boolean)
  {
    this.Sources.next(msgg);
  }
  Search(searchmsg:string)
  {
    this.searchSource.next(searchmsg);
  }
  dataCard(value: boolean){
    this.card.next(value)
  }

  NoteId(noteId:string){
    this.notesource.next(noteId);
  }
  colla(Message:string){
    this.collaboratorSource.next(Message);
  }
  changeLabel(value: boolean){
    this.labelSource.next(value)
  }
}
