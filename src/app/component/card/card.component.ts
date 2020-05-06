import { Component, OnInit, Input, Inject, Output, EventEmitter } from '@angular/core';
import { Subject } from 'rxjs';
import { NoteService } from 'src/app/Services/note.service';
import { Router } from '@angular/router';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatDialog, MatSnackBar, MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  @Output() output: EventEmitter<any> = new EventEmitter();
  constructor(@Inject(MAT_DIALOG_DATA) public data: any,
  private dialog:MatDialogRef<CardComponent>, private service :NoteService ) { }

  passData: Note=new Note();
  ngOnInit(): void {
  }

  updateNote(id,title, description) {
    debugger;
    this.passData.Id=id;
    this.passData.Title=title;
    this.passData.Description=description;
    console.log(this.passData);
    this.service.UpdateNote(id,title,description,null,null).subscribe(response => {
      console.log(response);
      this.dialog.close();
    });
    //this.dialog.close({ updateData: this.passData });
    
  }
  Function(event){
    this.dialog.close({result:event});
  }
}
