import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { Route } from '@angular/compiler/src/core';
import { MatSnackBar } from '@angular/material';
import { Subject } from 'rxjs';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-getnote',
  templateUrl: './getnote.component.html',
  styleUrls: ['./getnote.component.scss']
})
export class GetnoteComponent implements OnInit {
  reminderData: any = "";
  setColor = '#FFFFF';
  isArchive: any = false;
  value: boolean = false;
  constructor(private serviceobj:NoteService,private bar:MatSnackBar) { }
  @Output() childEvent = new EventEmitter<any>();
  parentSubject: Subject<any> = new Subject();
  flag = true;
  bgColor = '#FFFFF';
  message: string;

  noteTitle = new FormControl('',
  );
  noteContent = new FormControl('',
  );
  ngOnInit() {

  }
  receiveMessage($event) {
    this.message = $event;
    this.bgColor = $event.color;
  }
  receiveReminderEvent($event) {
    console.log("event received for reminder: ", $event)
    this.reminderData = $event;
    console.log(this.reminderData)
  }
  receiveSetColorEvent($event) {
    console.log("change color event received");
    this.setColor = $event;
    console.log(this.setColor);
  }

  receiveArchiveEvent($event) {
    this.isArchive = $event;
    this.bar.open("archived", "", { duration: 1000 })
  }
  reverseFlag() {
    this.flag = !this.flag;
  }

  removeReminder() {
    this.reminderData = "";
  }
  addNote() {
    this.flag=!this.flag;
    try{
      if (this.noteTitle.value == '' || this.noteContent.value == '') { throw new Error('Note must contain a title and content'); }

      const newNoteData = {
        userId: localStorage.getItem('userId'),
        noteTitle: this.noteTitle.value,
        noteContent: this.noteContent.value,
        reminder: this.reminderData,
        color: this.setColor,
        isPined: this.value,
        isArchived: this.isArchive.isArchived,
        isDeleted: false,
        img: ""
      };
      this.serviceobj.AddNote(newNoteData,'AddNote').subscribe(
        data => {
          var pushData = (data as any).response.result;
          this.parentSubject.next(pushData);

          this.bar.open('Your note has been saved successfully', '', { duration: 2000 });
        },
        error => {
          this.bar.open('Note not saved', '', { duration: 2000 });
          console.log('error response: ', error);
        }
      );
    }catch(arr){
      this.bar.open(arr,'',{duration:2000});
    }
  }


}
