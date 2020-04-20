import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { NoteService } from 'src/app/Services/note.service';
import { Route } from '@angular/compiler/src/core';
import { MatSnackBar, MatDialog } from '@angular/material';
import { notEqual } from 'assert';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-icon',
  templateUrl: './icon.component.html',
  styleUrls: ['./icon.component.scss']
})
export class IconComponent implements OnInit {
 @Input() param:any;
  @Input() notes:any;
  @Output() setColorEvent = new EventEmitter<any>();
  @Output() reminderEvent= new EventEmitter<any>();
  @Output() archiveEvent = new EventEmitter<any>();
  @Output() outputProperty = new EventEmitter<any>();
  value: Label = new Label();
  color: Note = new Note();
   bin:boolean;
  labels: any;

  constructor(private serviceobj:NoteService,public dialog: MatDialog,private sharing:DatasharingService,
    private bar:MatSnackBar) { }

  ngOnInit(): void {
  }
  
  archive(id: number ) {
    // debugger;
    this.archiveEvent.emit(id);
   // this.color.Id = id;
    // if(notes==0)
    //   this.color.archive=true;  
    // else
    // this.color.archive=false;
    this.serviceobj.IsArchive(id).subscribe( Response => console.log(Response));
  location.reload();
  }
  unarchive(id){
this.archiveEvent.emit(id);
//this.color.Id=id;
this.serviceobj.unarchive(id).subscribe(Response=>{
  console.log(Response);
})
location.reload();
  }
  //working
  delete(id: number) {
    //this.color.Id = id;
    // if (notes.istrash) 
    //   this.color.bin = false;
    // else 
    //   this.color.bin = true;
      this.serviceobj.emptybin(id).subscribe(response => {
        console.log(response);
      })
    
 location.reload();
  }

  //working
  
  setcolor(id, changeColor) {
//    debugger;
    this.setColorEvent.emit("done");
    this.serviceobj.color(id,changeColor).subscribe(Response=>{
      console.log(Response);
    })
   location.reload();
  }
  addLabel(labels) {

    console.log(labels);
    this.value.noteid = labels;
    const dialogRef = this.dialog.open(EditlabelComponent, {
      data: { labels:labels },
      //panelClass: 'custom-dialog-container'
    });
    dialogRef.afterClosed().subscribe(result => {
      labels = result;
    });
  }
  addRemainder(){
    this.serviceobj.Reminder(this.notes.id, "Today, 8:00 PM").subscribe((status)=>{
     if (status != null){
       this.sharing.upmessage(true);
       this.bar.open('Remainder added.','', {duration: 2000});
     }
       });
      }

  reminder() {
    // debugger;
    labels:localStorage.getItem('labels');
     this.reminderEvent.emit(this.labels);
   
    const dialogRef = this.dialog.open(EditreminderComponent, {
      data: { labels: this.labels },
      //panelClass: 'custom-dialog-container'
    });
    dialogRef.afterClosed().subscribe(result => {
   this.labels = result;
    });
  }
  addImage(id){
    const dialogR=this.dialog.open(ImageuploadComponent,{
      width:'450px',
      height:'400px',data:id
    });

  }
  collaborator(){
    const display=this.dialog.open(CollaboratorComponent,{
       data:this.notes
    });
    display.afterClosed().subscribe(result=>{
      console.log('closed');
    });
  }
arrayofColors = [
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
}
