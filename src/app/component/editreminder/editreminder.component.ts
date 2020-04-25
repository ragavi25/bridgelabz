import { Component, OnInit, Inject, Output, EventEmitter } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MAT_DIALOG_DATA } from '@angular/material';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-editreminder',
  templateUrl: './editreminder.component.html',
  styleUrls: ['./editreminder.component.scss']
})
export class EditreminderComponent implements OnInit {
  time = '8:00 AM';
  repeat = 'daily';
  reminder: Note = new Note();;
  day = 'Today';
  nodeId: any;
  todayString: string = new Date().toDateString();
  @Output() reminderEvent = new EventEmitter<any>();
  constructor(@Inject(MAT_DIALOG_DATA) public data: any, private noteobj: NoteService) { }
  ngOnInit(): void {
    console.log(this.data.labels);
  }

  setTime(time) {
    this.time = time;
  }

  setRepitation(repeat) {
    this.repeat = repeat;
  }

  save(date) {
    // debugger;
    this.reminderEvent.emit(date);
    console.log(date);
    let str: any;
    if (date != "") {
      let v = new Date(date);
      str = v.toDateString();
    }
    else {
      str = this.day;
    }
    var id=1;
    // 'Id':id;
    // Reminder = str + " " + this.time;
     this.noteobj.Reminder(date,id).subscribe(Response => {
      console.log(Response);
    })
    console.log(this.reminder);

  }

}
