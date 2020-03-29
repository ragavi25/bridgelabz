import { Component, OnInit } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { CardComponent } from '../card/card.component';
import { AppModule } from 'src/app/app.module';
import { NotemodelModule } from '../notemodel/notemodel.module';

@Component({
  selector: 'app-display-note',
  templateUrl: './display-note.component.html',
  styleUrls: ['./display-note.component.scss']
})
export class DisplayNoteComponent implements OnInit {
  note:NotemodelModule=new NotemodelModule();
  pinNotes:NotemodelModule[];
  unPinNotes:NotemodelModule[];
  allNotes:NotemodelModule[];
  user=JSON.parse(localStorage.getItem('user'));
  constructor(
    private serviceobj:NoteService,
    private Datasharing:DatasharingService,
    private bar:MatSnackBar,
    private dialog:MatDialog,
  ) { }

  ngOnInit() {
    
    this.getNotes();
  }
  
  
getNotes(){
  this.serviceobj.Getnote(this.user.id).subscribe((status :any)=>{
    this.allNotes=status;
  });
}
pin(noteId:number,notes){
  if(notes.pinned=='0'){
    notes.pinned='1';
    this.serviceobj.Ispin(noteId).subscribe(Response=>{
      console.log('Note Pinned');
    })
  }
  else{
    notes.pinned='1';
    this.serviceobj.Unpin(noteId).subscribe(Response=>{
      console.log('UNPinned');
    })
  }
}
archive(noteId:number,notes){
  if(notes.isarchive=="0"){
    notes.isarchive="1";
    this.serviceobj.IsArchive(noteId).subscribe(Response=>{
      console.log('Archived');
    })
  }
  else{
    notes.isarchive = '0';
    this.serviceobj.IsArchive(noteId).subscribe(Response=>{
      console.log('unarchived');
    })
  }
}
bin(noteId:number,notes){
  if(notes.isbin=="0"){
    notes.isbin="1";
    this.serviceobj.emptybin(noteId).subscribe(Response=>{
      console.log('Binned');
    })
  }
  else{
    notes.isbin='0';
    this.serviceobj.emptybin(notes).subscribe(Response=>{
      console.log('empty');
    })
  }
}
setcolor(noteId,colorname){
  this.serviceobj.color(noteId,colorname).subscribe(Response=>{
    console.log("done");
  })
}
notes = [
  { color: "rgb(255, 179, 255)", name: "pink", title: "hakini", description: "beauty", isarchived: true, isbin: "0",pinned: true },
  { color: "rgb(203,240,248)", name: "blue", title: "nitheshraj", description: "beauty", isarchived: true, isbin: "0",pinned: true },
  { color: "green", name: "green", title: "Ramya", description: "beauty", isarchived: false, istrash: "1" ,pinned: true},
  { color: " rgb(174,203,250)", name: "Dark blue", title: "vachi", description: "beauty", isarchived: false, isbin: "1" ,pinned: true},
  
]

arrayofColors = [
  [
    { color: "rgb(255,255,255)", name: "white" },
    { color: "rgb(255,0,0)", name: "red" },
    { color: "rgb(255,165,0)", name: "orange" },
    { color: "rgb(255,255,0)", name: "yellow" }
  ],
  [
    { color: "rgb(0,128,0)", name: "green" },
    { color: "rgb(0,128,128)", name: "teal" },
    { color: "rgb(0,0,255)", name: "blue" },
    { color: "rgb(0,0,139)", name: "dark blue" }
  ],
  [
    { color: "rgb(128,0,128)", name: "purple" },
    { color: "rgb(255,192,203)", name: "pink" },
    { color: "rgb(165,42,42)", name: "brown" },
    { color: "rgb(128,128,128)", name: "gray" }
  ]
]
}

