import { Component, OnInit, Input, Output, EventEmitter, Inject } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormControl } from '@angular/forms';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { ImageCropperModule, ImageCroppedEvent, base64ToFile } from 'ngx-image-cropper';
import { NoteComponent } from '../note/note.component';

@Component({
  selector: 'app-editcard',
  templateUrl: './editcard.component.html',
  styleUrls: ['./editcard.component.scss']
})
export class EditcardComponent implements OnInit {
  @Input() notes:any;
  @Input() labels:any;
  color:any;
  edit: boolean = false;
  isbin:boolean;
  constructor(private noteobj:NoteService,private datasharing:DatasharingService,private dialog:MatDialog) { }

  ngOnInit(): void {
  }
  Update(note)
  {
    console.log("AllNotes"+note);
    if(note.isbin!=true)
    {
      const Ref=this.dialog.open(NoteComponent,{
        data:{note:note},
        panelClass:'custom-dialog-container'
      });
      Ref.afterClosed().subscribe(result=>{
        note=result;
      });
    }
    else{
      console.log("cont edit");
    }
  }
  delete(id){
    this.color.id=id;
    this.noteobj.deletelabel(this.color).subscribe(Response=>{
      console.log(Response);
    })
    window.location.reload();
  }
  deleteReminder(id){
    this.color.id=id;
    this.noteobj.removereminder(this.color).subscribe(Response=>{
      console.log(Response);
    })
    window.location.reload();
  }

}
