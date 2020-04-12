import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Label } from 'src/app/models/label.model';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-editlabel',
  templateUrl: './editlabel.component.html',
  styleUrls: ['./editlabel.component.scss']
})
export class EditlabelComponent implements OnInit {
  allLabelNames: any;
  edit: boolean = false;
  nameLabel: any;
  labelname: Label = new Label();
  notes:Note=new Note();
  //EditLabelForm: FormGroup;
  constructor(private datashare:DatasharingService,private serviceobj:NoteService,
  private bar:MatSnackBar,public dialog:MatDialogRef<EditlabelComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any ) { }
  datas:any;

  ngOnInit(): void {
    //this.getlabel();
    // this.EditLabelForm = new FormGroup({
    //   newLabel: new FormControl()
    // });
    this.allLabels();
   
  }
  createLabels(data) {
    // debugger;
    if (data != null) {
      this.labelname.labelname = data;
        //this.labelname.noteid =this.data.labels.nodeid;
        this.labelname.noteid = this.data.labels.id;
      this.labelname.userid=1;
      this.serviceobj.addlabel(this.labelname).subscribe(response => {
      console.log(response);
      
      });
    }
    else if (data == null) {
      console.log("Label is empty..");
    }
  }

  done() {

  }
  allLabels() {
    this.serviceobj.getlabel().subscribe(Response => {
      this.allLabelNames = Response;
      console.log(Response);
    })
  }

  deleteLabel(id) {
    this.labelname.id = id;
    this.serviceobj.deletelabel(this.labelname).subscribe(response => {
      console.log(response);
    })
    console.log("your output: " + id);
    // window.location.reload();
  }

  editLabel() {
    this.edit = true;
  }
