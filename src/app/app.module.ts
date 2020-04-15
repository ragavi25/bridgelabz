import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatMenuModule } from '@angular/material/menu';
import {MatListModule} from '@angular/material/list';
import {MatGridListModule} from '@angular/material/grid-list';
import {DragDropModule} from '@angular/cdk/drag-drop';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { MAT_DIALOG_DEFAULT_OPTIONS } from '@angular/material';

import { ReactiveFormsModule } from '@angular/forms';
import { MatInputModule, MatSnackBar, MatDialog } from '@angular/material';
import { MatCardModule } from '@angular/material/card';
import { RouterModule, Router } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatIconModule } from '@angular/material/icon';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatDialogModule,MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {MatNativeDateModule} from '@angular/material';
//import { MatMomentDateModule } from "@angular/material-moment-adapter";


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './component/login/login.component';
import { RegisterComponent } from './component/register/register.component';
import { ForgotpasswordComponent } from './component/forgotpassword/forgotpassword.component';
import { HomeComponent } from './component/home/home.component';
import { AccountService } from './Services/account.service';
import { CommonModule } from '@angular/common';
import { ServiceCardComponent } from './component/service-card/service-card.component';
import { NoteComponent } from './component/note/note.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { DisplayNoteComponent } from './component/display-note/display-note.component';
import { GetnoteComponent } from './component/getnote/getnote.component';
import { PinComponent } from './component/pin/pin.component';
import { ReminderComponent } from './component/reminder/reminder.component';
import { ArchiveComponent } from './component/archive/archive.component';
import { BinComponent } from './component/bin/bin.component';
import {MatSidenavModule} from '@angular/material';
import {MatToolbarModule} from '@angular/material/toolbar'; 
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { CardComponent } from './component/card/card.component';
import { IconComponent } from './component/icon/icon.component';
import {NgxMaterialTimepickerModule} from 'ngx-material-timepicker';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {  MatCheckboxModule } from '@angular/material';
import { LabelComponent } from './component/label/label.component';
import { EditcardComponent } from './component/editcard/editcard.component';
import { CollaboratorComponent } from './component/collaborator/collaborator.component';
import { NoteService } from './Services/note.service';
import { EditlabelComponent } from './component/editlabel/editlabel.component';
import { ProfilepicComponent } from './component/profilepic/profilepic.component';
import { NewiconComponent } from './component/newicon/newicon.component';
import { EditreminderComponent } from './component/editreminder/editreminder.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ForgotpasswordComponent,
    HomeComponent,
    ServiceCardComponent,
    NoteComponent,
    DisplayNoteComponent,
    GetnoteComponent,
    PinComponent,
    ReminderComponent,
    ArchiveComponent,
    BinComponent,
    DashboardComponent,
    CardComponent,
    IconComponent,
    LabelComponent,
    EditcardComponent,
    CollaboratorComponent,
    EditlabelComponent,
    ProfilepicComponent,
    NewiconComponent,
    EditreminderComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    HttpClientModule,
    MatInputModule,
    MatMenuModule,
    MatToolbarModule,
    MatSelectModule,
    MatButtonModule,
    MatListModule,
    MatSidenavModule,
    MatAutocompleteModule,
    ReactiveFormsModule,
    MatCheckboxModule,
    MatNativeDateModule,
    MatCardModule,
    MatIconModule,
    FormsModule,
    FlexLayoutModule,
    MatSnackBarModule,
    DragDropModule,
    MatDialogModule,
    MatGridListModule,
    RouterModule,
    AppRoutingModule,
    NgxMaterialTimepickerModule,
    MatDatepickerModule,
   RouterModule.forRoot([])
    
    
  ],
  entryComponents:[CollaboratorComponent],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA
],
  providers: [AccountService,NoteService,{ provide: MatDialogRef, useValue: {} },
    { provide: MAT_DIALOG_DATA, useValue: [] },],
  bootstrap: [AppComponent]
})
export class AppModule { }
