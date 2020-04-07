import { Component, OnInit } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { Router } from '@angular/router';
import { error } from '@angular/compiler/src/util';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-bin',
  templateUrl: './bin.component.html',
  styleUrls: ['./bin.component.scss']
})
export class BinComponent implements OnInit {
  notes: any = [
    { noteId:1,color: "rgb(255, 179, 255)", name: "pink", tittle: "hgkhgh", description: "gfhgfh", archiv: true, bin: "0",pin: true }
  ];
  noteView : String = " wrap";
  noteId:any;
  constructor(
    private serviceobj:NoteService,private router:Router,private bar:MatSnackBar,
  ) { }

  ngOnInit() {
  }
  getbin()
  {
    this.serviceobj.getbin().subscribe(data=>{
      console.log("Archive component",data);
      this.notes=data['result'];
      console.log(this.notes)
    },
    error=>{
      console.log("Error Archive",error);
    })
  }
  emptyBin()
  {
    this.serviceobj.emptybin(this.noteId).subscribe(
      data=>{
        console.log("Bin",data);
        this.getbin();
      },
      error=>{
        console.log("Error at bin",error);
      }
    )
  }
  getDetails(note)
  {
    this.noteId=note.Id;
    console.log(this.noteId);
  }
  deleteForever()
  {
    try{
      if(this.noteId!=0)throw "note id missing"
      this.serviceobj.deleteforever(this.noteId).subscribe(data=>{
        this.getbin();
        console.log("Delete note forever?",data);
      },
      error=>{
        console.log("error");
      })
    }
    catch(arr){
      this.bar.open(arr," ",{duration:3000});
    }
  }
  restore()
  {
    const res={
      'noteId':this.noteId
    }
    this.serviceobj.restore(res).subscribe(
      data=>{
        this.bar.open("Note restored"," ", {duration:3000});
        this.getbin();
      },
      error=>{
        this.bar.open("Restored Failed"," ",{duration:3000});
      }
    )
  }
}
