import { Component, OnInit, Inject } from '@angular/core';
import { ImageCroppedEvent } from 'ngx-image-cropper';
import { NoteService } from 'src/app/Services/note.service';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatSnackBar, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-profilepic',
  templateUrl: './profilepic.component.html',
  styleUrls: ['./profilepic.component.scss']
})
export class ProfilepicComponent implements OnInit {
  value:boolean=false;
  imageChangedEvent: any = '';
  croppedImage: any = '';
  constructor(private serviceobj:NoteService,private datashare:DatasharingService,private bar:MatSnackBar,
     @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
  }
  fileChangeEvent(event: any): void {
      this.imageChangedEvent = event;
  }
  imageCropped(event: ImageCroppedEvent) {
      this.croppedImage = event.base64;
  }
  selectFiles($event){
    this.imageChangedEvent=$event;
  }
  changevalue(){
    this.value=true;
  }
  addprofile(croppedImage){
    console.log("Profile Image",croppedImage);
    this.serviceobj.UploadImage(this.data.id,croppedImage).subscribe(data=>{
      console.log(data);
      
    })
  }
}
