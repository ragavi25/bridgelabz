import { Component, OnInit, Input } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { CardComponent } from '../card/card.component';
import { AppModule } from 'src/app/app.module';
import { Subject } from 'rxjs';
import { ThrowStmt } from '@angular/compiler';

@Component({
  selector: 'app-display-note',
  templateUrl: './display-note.component.html',
  styleUrls: ['./display-note.component.scss']
})
export class DisplayNoteComponent implements OnInit {  color: Note = new Note();
  param: any;
  labelNotes:any;
  gridView:any;
  allnotes:any;
  constructor(private router:Router,private noteobj:NoteService,private route: ActivatedRoute) { }

  ngOnInit() {
    this.getLabelNote();
    this.getNotes();
    

    this.route.queryParams.subscribe(params => {
      this.param = params['page'];
      this.gridView=  params['view'];
    });
  }

  getNotes(){
    this.noteobj.Getnote().subscribe(data => {
      console.log(data);
      this.allnotes=data;
     // console.log(data);
    });
      }

  getLabelNote()
  {
    this.noteobj.getlabel().subscribe(Response => {
      this.labelNotes=Response;
    })
  }

}
