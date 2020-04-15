import { Component, OnInit, Input, Inject } from '@angular/core';
import { Subject } from 'rxjs';
import { NoteService } from 'src/app/Services/note.service';
import { Router } from '@angular/router';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatDialog, MatSnackBar, MAT_DIALOG_DATA } from '@angular/material';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any, private service :NoteService ) { }

  passData: Note=new Note();
  ngOnInit(): void {
  }

  updateNote(id,title, description) {
    debugger;
    this.passData.Id=id;
    this.passData.Description=description;
    this.passData.Title=title;
    // console.log(this.passData);
    this.service.UpdateNote(this.passData).subscribe(response => {
      window.location.reload();
      console.log(response);
    });
  }
}
