import { Component, OnInit, Input } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { MatSnackBar } from '@angular/material';
import { DatasharingService } from 'src/app/Services/datasharing.service';

@Component({
  selector: 'app-pin',
  templateUrl: './pin.component.html',
  styleUrls: ['./pin.component.scss']
})
export class PinComponent implements OnInit {

  @Input() getid;
  constructor(private serviceobj:NoteService,private bar:MatSnackBar,private datasharing:DatasharingService) { }

  ngOnInit() {
    
  }
  Pin(){
    this.serviceobj.Ispin(this.getid.id).subscribe((result)=>{ 
      if(result!=null){
        this.datasharing.dataMessage(true);
        this.bar.open('Pinned',' ',{duration:3000});
      }
    })
  }
  Unpin(){
      this.serviceobj.Unpin(this.getid.id).subscribe((result)=>{
        if(result!=null){
          this.datasharing.dataMessage(true);
          this.bar.open('UnPinned',' ',{duration:3000});
        }
      })
  }


}
