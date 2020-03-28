import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { NoteService } from 'src/app/Services/note.service';
import { Route } from '@angular/compiler/src/core';
import { MatSnackBar, MatDialog } from '@angular/material';
import { notEqual } from 'assert';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-icon',
  templateUrl: './icon.component.html',
  styleUrls: ['./icon.component.scss']
})
export class IconComponent implements OnInit {
  labels: any = [];
  Menu=false;
  date = new FormControl('');
  time = new FormControl('');
  checked = new FormControl(false);
  constructor(private serviceobj:NoteService,
    private bar:MatSnackBar,private dialog:MatDialog)  { }
    @Input() childMessage: any = "";
  @Input() user;
  @Input() test: string;
  @Output() reminderEvent = new EventEmitter<any>();
  @Output() updateColor = new EventEmitter<any>();
  @Output() changeColorForEditCard = new EventEmitter<any>();
  @Output() DeletedNoteToBin = new EventEmitter<any>();
  @Output() archiveFromCardEvent = new EventEmitter<any>();
  @Output() archiveFromCard = new EventEmitter<any>();
  @Output() reminderOnCards= new EventEmitter<any>();
  @Output() updateLabel = new EventEmitter<any>();
  @Output() imageUpdate= new EventEmitter<any>();
  ngOnInit() {
    this.getLabels();
  }
  colorArray = [[
    { 'color': 'rgb(255, 255, 255)', 'name': 'White' },
    { 'color': 'rgb(242, 139, 130)', 'name': 'Red' },
    { 'color': 'rgb(251, 188, 4)', 'name': 'Orange' },
    { 'color': 'rgb(255, 244, 117)', 'name': 'Yellow' }]]


  Reminder(){
    const data=this.date.value.toLocaleDateString() + "," + " " + this.time.value;
    console.log("reminder:",data);
    this.reminderEvent.emit(data);
    this.reminderOnCards.emit(data);
  }
  archiveNote(){
    try{
      if(this.user.note.id==undefined || this.user.note.id.trim()=="")throw "noteid not found"
      const data={
        'id':this.user.id,
        'isArchived':true,
      }
      this.serviceobj.IsArchive(data).subscribe(res=>{
        this.bar.open("Note archived"," ",{duration:2000})
        this.archiveFromCard.emit("done");
      },
      error=>{
        this.bar.open("Archive Failed"," ",{duration:2000});
        console.log(Error);
      })
    }catch(arr){
      this.bar.open("Archived Failed"," ",{duration:2000});
    }
  }
  ChangeColor(colorId){
    this.changeColorForEditCard.emit(colorId);
    if(this.childMessage!=""){
      const colordata={'noteId':this.childMessage,'color':colorId}
      this.serviceobj.addcolor(colordata).subscribe(data=>{this.updateColor.emit(colorId);},
      error=>{
        console.log('not change color',error);
      });
    }
    }
    deleteNote() {
      var deletedata;
      if(this.childMessage=""){
       deletedata={
        'id':this.childMessage
      }
      }
      else{
         deletedata=
        {
        'id' : this.childMessage,
        }   
      }
      this.serviceobj.deletenote(deletedata).subscribe(
        data=>{
          this.bar.open("Note binned"," ",{duration:2000});
          this.reminderOnCards.emit("done");
          this.DeletedNoteToBin.emit("done");
        },
        error=>{
          this.bar.open("Note not delete"," ",{duration:2000});
        }
      );
    }
    getLabels(){
      this.serviceobj.getlabel().subscribe(
        data=>{
          this.labels=(data as any).response;
        },
        error=>{
          console.log(error);
        }
      )
    }
    checkBox(label){
      if(this.checked.value==false){
        const data={
          'id':label.id,
          'noteId':this.user.note.id,
          'labelData':{
            'labelName':label.labelName,
            'labelId':label.id,
          }
        }
        this.serviceobj.addlabel(data).subscribe(
          data=>{
            this.bar.open("Label added","",{duration:2000});
            this.updateColor.emit("done");
          });
       }
      }
      uploadImage(inputImage){}
      openCollab(user){}
     
 }


