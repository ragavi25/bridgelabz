import { Component, OnInit, Input } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialog } from '@angular/material';

@Component({
  selector: 'app-editcard',
  templateUrl: './editcard.component.html',
  styleUrls: ['./editcard.component.scss']
})
export class EditcardComponent implements OnInit {
  @Input() childMessage: any = "";
  labels: any = [];

  constructor(private serviceobj:NoteService,
    private bar:MatSnackBar,private dialog:MatDialog) { }

  ngOnInit(): void {
  }
  arrayOfColors = [
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
  deleteNote(){
    var deletedata;
    if(this.childMessage=""){
     deletedata={
      'id':this.childMessage,
      'isDeleted':true,
    }
    }
    else{
       deletedata=
      {
      'id' : this.childMessage,
      'isDeleted':true,
      }   
    }
    this.serviceobj.deletenote(deletedata).subscribe(
      data=>{
        this.bar.open("Note binned"," ",{duration:2000});
        //this.reminderOnCards.emit("done");
        //this.DeletedNoteToBin.emit("done");
        //this.sendDeletedNoteInfoEvent.emit("done");
      },
      error=>{
        this.bar.open("Note not delete"," ",{duration:2000});
      }
    );

  }

}
