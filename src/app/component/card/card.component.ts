import { Component, OnInit, Input } from '@angular/core';
import { Subject } from 'rxjs';
import { NoteService } from 'src/app/Services/note.service';
import { Router } from '@angular/router';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatDialog, MatSnackBar } from '@angular/material';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';
import { EditCardComponent } from '../edit-card/edit-card.component';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  @Input()
  parentsub:Subject<any>;
  @Input()
  Userdata=JSON.parse(localStorage.getItem('Userdata'));
   notes:any=[];
   noteId: any;
   updateColor: any;
   noteView : string = "row view";
   title1:any;
   des:any;
   user: any = "";
   noteData: any = "";
   labels : any;
   value: boolean = false;
   cards: any;
   pincard: any;
   Unpincard: any;
   note:any = []
  constructor(
    private serviceobj:NoteService,
    private router:Router,
    private datasharing:DatasharingService,
    private  dialog:MatDialog,
    private bar :MatSnackBar,
  ) { }
  ngOnInit() {
    this.getNote();
    this.parentsub.subscribe(data=>{
      console.log(data);
      if(data.isPin==false){
        var res={notes:data}
        this.Unpincard.push(data);
        this.router.navigate(['/dashboard'])
      }
      else{
        var res1={notes:data}
        this.pincard.push(data);
      }
    });
    this.datasharing.Message.subscribe(re=>this.noteView=re);
    this.datasharing.collaborator.subscribe(ress=>this.getNote());
  }
  drop(event: CdkDragDrop<any[]>){
    moveItemInArray(this.notes,event.previousIndex,event.currentIndex);
  }
  UpdateNote(note){
    const a=this.dialog.open(EditCardComponent,{data:note});
    this.dialog.afterAllClosed.subscribe(result=>{
      this.serviceobj.UpdateNote(this.noteId,this.title1,this.des,this.Userdata.email).subscribe(data=>{
        this.getNote();
      },
      error=>{
        this.bar.open('Not Updated',' ',{duration:2000});
        console.log('Error',error);
      }
      )
    })
  }
  getNote(){
    const data={userId:localStorage.getItem('userId')};
    this.serviceobj.Getnote(data).subscribe(
      res=>{
        this.notes=data['response'];
        this.cards=(data as any).response;
        this.pincard=this.cards.filter(function(a){
          return (a.notes.isPin==true);
        });
        this.Unpincard=this.cards.filter(function(a){
          return(a.notes.isPin==false);
        });
        console.log("pinned note:",this.pincard);
        console.log("Unpinned note",this.Unpincard);
      },
      error=>{
        this.bar.open("eroor occuring loding note"," ",{duration:3000});
        console.log(error);
      });
  }
  Changepin(note){
    try{
      if(note.id==undefined)throw "not perform";
      const Updatepin={
        'id':note.id,
        'ispin':!note.ispin,
      }
      this.serviceobj.Ispin(Updatepin).subscribe(data=>{this.bar.open("Done"," ",{duration:3000});
      this.getNote();
     },
     error=>{
       this.bar.open("Failed"," ",{duration:2000});
       console.error(error);
     } )
    }
    catch(arr){
      this.bar.open(arr," ",{duration:2000});
    }
  }
  removeReminder(note)
  {
    note.reminder=" ";
    this.serviceobj.removereminder(note).subscribe(data=>{this.getNote();
    this.bar.open('Reminder deleted'," ",{duration:2000});
  },
  error=>{
    this.bar.open('Not delete',' ',{duration:2000});
    console.log('error',error);
  })
  }
  deleteLabel(label,note){
    const deletelabels={
      'noteId':note.noteId,
      'labelname':label.labelname,
    }
    this.serviceobj.deletelabel(deletelabels).subscribe(data=>{
      this.bar.open("Label deleted"," ",{duration:2000});
      this.getNote();
    },
    error=>{
      this.bar.open("not deleted label"," ",{duration:2000});
    })
  }
  UpdateallNotes(note){
    console.log(note.id);
    this.noteId=note.id;
    console.log("Notes id",this.noteId);
    this.user=note,
    this.datasharing.NoteId(this.noteId);
  }
  UpdateColor($event){
    this.updateColor=$event;
    this.getNote();
  }
  DeletedNoteToBin($event){
    this.getNote();
  }
  ArchiveFromCard($event){
    this.getNote();
  }
  ReminderOnCard($event){
    const res={'id':this.noteId,'reminder':$event}
    this.serviceobj.Reminder(res).subscribe(data=>{
      this.getNote();
      this.bar.open("Reminder added"," ",{duration:2000});
    },
    error=>{
      console.error(error);
    })
  }
  UpdateLabels($event){
    console.log($event);
    const res={'id':this.noteId,'labels':$event}
    this.serviceobj.updatelabel(res).subscribe(data=>{ this.getNote();
      this.bar.open("Label added"," ",{duration:2000});
    },
    error=>{
      console.error(error);
    }) 
  }
  ImageUpdate($event){
    const res={'id':this.noteId,'img':$event}
    this.serviceobj.UploadImage(res).subscribe(data=>{ this.getNote();
      this.bar.open("Label added"," ",{duration:2000});
  },
  error=>{
    console.error(error);
  })
  }
}

