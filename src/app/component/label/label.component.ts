import { Component, OnInit, Inject } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { NOTINITIALIZED } from 'dns';
import { Route } from '@angular/compiler/src/core';
import { ActivatedRoute } from '@angular/router';
import { ThrowStmt } from '@angular/compiler';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.scss']
})
export class LabelComponent implements OnInit {
  param: any;
  allNotes: Note=new Note();
  labelNotes:any;
  gridView:any;
  constructor(private serviceobj: NoteService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.getAllNotes();
    this.getLabelNote();
    this.route.queryParams.subscribe(params => {
      this.param = params['page'] ;
      this.gridView= params['view'];
      console.log(this.param);
    });
  }
  getAllNotes() {
    // debugger;
    this.serviceobj.Getnote().subscribe(Response => {
      console.log(Response);
    });
  }

  getLabelNote()
  {
    this.serviceobj.getlabel().subscribe(Response => {
    this.labelNotes=Response;
      console.log("------------------");
      console.log(Response);
      console.log("------------------");
    })
  }
}
