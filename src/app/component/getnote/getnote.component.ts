import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { Route } from '@angular/compiler/src/core';
import { MatSnackBar, MatDialog } from '@angular/material';
import { Subject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { ImageuploadComponent } from '../imageupload/imageupload.component';
import { EditlabelComponent } from '../editlabel/editlabel.component';

@Component({
  selector: 'app-getnote',
  templateUrl: './getnote.component.html',
  styleUrls: ['./getnote.component.scss']
})
export class GetnoteComponent implements OnInit {
  //reminder= '5/9/2020';
  //setColor = '#FFFFF';
  archive: any = false;
  value: boolean = false;
  allNotes: any;
  @Input() reminder: any;
  @Input() labelname:any;
  time = "8:00 AM";
  repeat = "daily";
  day = "Today";
  notes: any;
  constructor(private serviceobj:NoteService,private bar:MatSnackBar,public dialog: MatDialog) { }
  @Output() childEvent = new EventEmitter<any>();
  flag = true;
  bgColor = 'pink';
  message: string;
  changeColor:string;

  title = new FormControl('',
  );
  description = new FormControl('',
  );
  ngOnInit() {
    this.getNotes();

  }
  getNotes(){
    this.serviceobj.Getnote().subscribe((status :any)=>{
      this.allNotes=status;
    });
  }
  receiveMessage($event) {
    this.message = $event;
    this.bgColor = $event.color;
  }
  ReminderEvent($event) {
    console.log("event received for reminder: ",$event);
    this.reminder = $event;
    console.log(this.reminder);
  }
  reciveSetColorEvent($event) {
    debugger;
    $event='rgb(255, 179, 255)';
    console.log("change color event received");
    this.setColor = $event;
    console.log(this.setColor);
  }

  ArchiveEvent(event) {
    this.archive = event;
    console.log(this.archive);
    this.bar.open("archived", "", { duration: 1000 })
  }
  reverseFlag() {
    this.flag = !this.flag;
  }
  addRemainder(){
    this.serviceobj.Reminder(this.notes.id, "Today, 8:00 PM").subscribe((status)=>{
     if (status != null){
       //this.sharing.upmessage(true);
       this.bar.open('Remainder added.','', {duration: 2000});
     }
     //this.output.emit("done");
       });
      }
  removeReminder() {
    this.reminder= "";
  }
  addNote() {
    debugger;
    this.flag=!this.flag;
    try{
      if (this.title.value == '' || this.description.value == '') { throw new Error('Note must contain a title and content'); }

      const newNoteData = {
       // nodeId: localStorage.getItem('nodeId'),
        title: this.title.value,
        description: this.description.value,
        archive: this.archive.archive,
        pin: this.value,
        changeColor: this.setColor,
        addImg: "",
        reminder: this.reminder,
        bin: false,
        labelname:this.labelname
      };
      this.serviceobj.AddNote(newNoteData).subscribe(
        data => {
          console.log(" Note",data);
       console.log(data);
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
  reverseValue() {
    this.value = !this.value;
  }
  setColor(Color) {
    this.changeColor = Color;
  }
  save(date) {
    let str: any;
    if (date != "") {
      let v = new Date(date);
      str = v.toDateString();
    }
    else str = this.day;
    this.reminder = str + " " + this.time;
  }
  collaborator(){
    const display=this.dialog.open(CollaboratorComponent,{
       data:this.notes
    });
    display.afterClosed().subscribe(result=>{
      console.log('closed');
    });
  }
  delete(id: number) {
    this.serviceobj.emptybin(id).subscribe(response => {
      console.log(response);
      //this.output.emit("done");
    })
}
  addLabel(labels) {

    console.log(labels);
   // this.value.noteid = labels;
    const dialogRef = this.dialog.open(EditlabelComponent, {
      data: { labels:labels },
      //panelClass: 'custom-dialog-container'
    });
    dialogRef.afterClosed().subscribe(result => {
      labels = result;
     // this.output.emit("done");
    });
  }
 
  addImage(){
    var id:1;
     const dialogR=this.dialog.open(ImageuploadComponent,{
       width:'450px',
       height:'200px',data:id
     });
 
   }

  close() {
    this.reminder = null;
  }

  closelabel() {
    this.labelname = null;
  }

  listOfColors = [
    [
      { color: "rgb(255, 179, 255)", name: "pink" },
      { color: "rgb(255, 255, 128)", name: "darkGolden" },
      { color: "rgb(200, 232, 104)", name: "yellow" },
      { color: " rgb(158, 136, 191)", name: "darkYellow" }
    ],
    [
      { color: "slategray", name: "grey" },
      { color: "rgb(153, 221, 255)", name: "Teal" },
      { color: "rgb(203,240,248)", name: "blue" },
      { color: "rgb(174,203,250)", name: "Dark blue" },
    ],
    [
      { color: "rgb(255, 153, 0)", name: "orange" },
      { color: "rgb(97, 191, 82)", name: "green" },
       { color: "white", name: "white" },
      { color: " rgb(196,174,251)", name: "purpule" }
  
    ]
  
  ]

  isArchive() { 
    if (this.archive == 0) {
      this.archive = 1;
      this.bar.open('Note Archived', 'Dismiss', { duration: 2000 });
    }
    else {
      this.archive = 0;
      this.bar.open('Note UnArchived', 'Dismiss', { duration: 2000 });
    }
  }
  setTime(value) {
    this.time = value;
  }

  setRepitation(value) {
    this.repeat = value;
  }

}
