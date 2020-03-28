import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { Subject } from 'rxjs';
import { Ng4LoadingSpinnerService } from 'ng4-loading-spinner';
import { MediaMatcher } from '@angular/cdk/layout';
import { NoteService } from 'src/app/Services/note.service';
import { MatDialog, MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { AccountService } from 'src/app/Services/account.service';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
 
      Query:MediaQueryList;
      nav=Array.from({ length: 5 }, (_, i) => `Nav Item ${i + 1}`);
      keepLink: any = "";
      display: any;
      userData: any = " ";
     icon: String = 'dashboard';
      viewToolTip: string;
      croppedImage: any = '';
      value = ' ';
      Search: any;
      labels = [];
     headerName:any;
    private QueryListener: () => void;
    parentSubject: Subject<any> = new Subject();

  constructor(
    private datasharing:DatasharingService,
    private roter:Router,
    private serviobj:NoteService,
    public dialog:MatDialog,
    media:MediaMatcher,
    Deactor:ChangeDetectorRef,
     ) {
       this.Query=media.matchMedia('(max-width:500px)');
       this.QueryListener=()=>Deactor.detectChanges();
       this.Query.addListener(this.QueryListener);
      }
  ngOnInit() {}
  ngOnDestory():void{
    this.Query.removeListener(this.QueryListener);
  }
  key(){
    this.datasharing.Search(this.Search);
  }
  icons(){
    if(this.icon==='view_agenda_outline'){
      this.icon='dashboard';
      this.datasharing.dataMessage('row primary');
    }
    else{
      this.icon='view_agenda_outline';
      this.datasharing.dataMessage('colum primary');
    }
    
  }
  Profile(){

  }
  logout(){
    localStorage.clear();
    this.roter.navigate(['/login']);
  }
  openEditLabelDialog(){}
  openEditLabel(){}
}
