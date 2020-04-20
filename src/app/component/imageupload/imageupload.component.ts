import { Component, OnInit, Inject } from '@angular/core';
import { NoteService } from 'src/app/Services/note.service';
import { DatasharingService } from 'src/app/Services/datasharing.service';
import { MatSnackBar, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { ImageCroppedEvent, base64ToFile } from 'ngx-image-cropper';

@Component({
  selector: 'app-imageupload',
  templateUrl: './imageupload.component.html',
  styleUrls: ['./imageupload.component.scss']
})
export class ImageuploadComponent implements OnInit {
  fileToUpload: File;
  filename;
  imageChangedEvent: any = '';
  croppedImage: any = '';
  
  constructor(private servceobj:NoteService,private datasharing:DatasharingService,
    private bar:MatSnackBar,public dialog:MatDialogRef<ImageuploadComponent>,
    @Inject(MAT_DIALOG_DATA)public data:any) { }

  ngOnInit(): void {
  }

  fileChangeEvent(event: any): void {
    this.filename = event.target.files[0].name;
    console.log(this.filename + " name");
    
    this.imageChangedEvent = event;
  }
imageCropped(event: ImageCroppedEvent) {
  this.croppedImage = base64ToFile(event.base64);
  this.fileToUpload = new File([this.croppedImage], this.filename);
}
addImage(){
  this.servceobj.addImage(this.data.id ,this.fileToUpload).subscribe((status :any) => {
    if(status != null)
    {
      this.datasharing.upmessage(true);
      this.dialog.close();
      this.bar.open('Image added','', {duration: 2000});
    }
});

}
onNoClick(){
  this.dialog.close();
}

}
