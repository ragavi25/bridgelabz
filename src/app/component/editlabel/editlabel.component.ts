import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-editlabel',
  templateUrl: './editlabel.component.html',
  styleUrls: ['./editlabel.component.scss']
})
export class EditlabelComponent implements OnInit {
  EditLabelForm:FormGroup;
  data='';
  constructor(private datashare:DatasharingService,private serviceobj:NoteService,
  private bar:MatSnackBar,public dialog:MatDialogRef<EditlabelComponent>,
  @Inject(MAT_DIALOG_DATA) public Labels: any ) { }

  ngOnInit(): void {
    
    this.EditLabelForm = new FormGroup({
      newLabel: new FormControl()
    });
    this.getlabel();
  }
  getlabel(){
    this.serviceobj.getlabel().subscribe(datas=>{
      console.log("getlabel data",(datas as any).response);
     this.Labels=(datas as any).response;
    },
    error=>{
      console.log(error);
    })
  }
  onNoClick(): void {
    this.dialog.close();
  }
  addlabel(){
    try{
      var noteId=localStorage.getItem('noteId');
       if(this.data.trim()=="")throw "Label cant empty"
       const add={
         'noteId':1,
         'labelname':this.data.trim(),  
       }      
       console.log(add);
       this.serviceobj.addlabel(add).subscribe(datas=>{
         this.bar.open("Label added","Done",{duration:2000});
        
         this.getlabel();
         console.log(datas);
       },error=>{
         this.bar.open("Label not added","",{duration:2000});
         console.log(error);
       })
     }catch(arr){
       this.bar.open(arr,"",{duration:2000});
     }
   }
  
  updateLabel(Label){
    this.serviceobj.updateLabel(Label.id,this.EditLabelForm.value.newLabel).subscribe((status)=>{
      if(status != null){
        this.datashare.changeLabel(true);
        this.datashare.upmessage(true);
        console.log("done");
        this.bar.open('Updated.','', {duration: 2000});
      }
    });
  }
  deleteLabel(Label){
    this.serviceobj.deletelabel(Label.id).subscribe((status)=>{
      if(status != null){
        this.datashare.changeLabel(true);
        this.datashare.upmessage(true);
        this.bar.open('Label Deleted.','', {duration: 2000});
      }
    });
  }
}
