import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './component/login/login.component';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './component/register/register.component';
import { ForgotpasswordComponent } from './component/forgotpassword/forgotpassword.component';
import { HomeComponent } from './component/home/home.component';
import { AppModule } from './app.module';
import { ServiceCardComponent } from './component/service-card/service-card.component';
import { NoteComponent } from './component/note/note.component';
import { DisplayNoteComponent } from './component/display-note/display-note.component';
import { ReminderComponent } from './component/reminder/reminder.component';
import { ArchiveComponent } from './component/archive/archive.component';
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { BinComponent } from './component/bin/bin.component';
import { CardComponent } from './component/card/card.component';
import { IconComponent } from './component/icon/icon.component';
import { GetnoteComponent } from './component/getnote/getnote.component';
import { LabelComponent } from './component/label/label.component';
import { CollaboratorComponent } from './component/collaborator/collaborator.component';
import { EditlabelComponent } from './component/editlabel/editlabel.component';


const routes: Routes = [
   {path : 'login', component: LoginComponent },
   {path :'register',component: RegisterComponent},
   {path :'forgot', component: ForgotpasswordComponent},
   {path :'fundoo', component: DashboardComponent,
   children:[
      {path :'',component:GetnoteComponent},
      {path:'getnote',component:HomeComponent},
      {path:'label',component:LabelComponent},
      {path :'Bin',component:BinComponent},
      {path :'archive',component:ArchiveComponent},
      {path:'reminder',component:ReminderComponent}
  ]},
   {path :'ServiceCard', component: ServiceCardComponent},
  // {path :'getnote',component:GetnoteComponent},
   //{path :'note',component:NoteComponent},
 // {path:'card',component:CardComponent},
   //{path:'colo',component:CollaboratorComponent},
  // {path:'icon',component:IconComponent}
  {path:'reminder',component:ReminderComponent}
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    //AppRoutingModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
