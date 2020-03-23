import { Component, OnInit } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar } from '@angular/material';
import { DatasharingService } from 'src/app/Services/datasharing.service';

@Component({
  selector: 'app-note',
  templateUrl: './note.component.html',
  styleUrls: ['./note.component.scss']
}) 
export class NoteComponent implements OnInit {
    data=JSON.parse(localStorage.getItem('data'));
    title;
    Note;
    notes;
    Notes;
  constructor(private noteobj:NoteService,private snackbar:MatSnackBar,private datasharing:DatasharingService) { }

  ngOnInit() {
  }
  note()
  {
    this.Notes=false;
    this.notes=true;
  }
  Close()
  {
   this.notes=false;
    this.Notes=true;
    if(this.title!=null || this.Note!=null)
    {
      this.noteobj.AddNote(this.title,this.Note,this.data.email).subscribe((status)=>{
        if(status !=null)
        {
          localStorage.setItem('datas',JSON.stringify(status));
          this.datasharing.dataMessage(true);
          this.snackbar.open('Added',' ',{duration:3000});

        }
      })
    }
  }

}
