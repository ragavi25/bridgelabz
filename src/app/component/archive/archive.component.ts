import { Component, OnInit } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { error } from 'protractor';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  notes:any=[];
  Archive:string="row wrap";
  constructor(private serviceobj:NoteService,private bar:MatSnackBar,private datascharing:DatasharingService,private dialog:MatDialog) { }
  ngOnInit() {
    this.getarchive();
    this.datascharing.Message.subscribe(msg=>this.Archive=msg);

  }
  getarchive(){
     this.serviceobj.GetArchive().subscribe(data=>{
       console.log("Archive Note",data);
       this.notes=data['result'];
     },error=>{
       console.log(error);
     })
  }
  removeReminder(note){

  }
  unarchive(note){
    console.log(note);
    try{
      if(note.id==undefined || note.id=="")throw "note missing"
      var res={
        'id':note.id,
      }
      this.serviceobj.unarchive(res).subscribe(data=>{
        this.bar.open("Unarchived","",{duration:2000});
        this.getarchive();
      },error=>{
        this.bar.open("not Unarchive","",{duration:2000});
      })
    }catch(arr){
      this.bar.open(arr,"",{duration:2000});
    }

  }
}
