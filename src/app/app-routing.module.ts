import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './component/login/login.component';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './component/register/register.component';
import { ForgotpasswordComponent } from './component/forgotpassword/forgotpassword.component';
import { HomeComponent } from './component/home/home.component';
import { AppModule } from './app.module';

const routes: Routes = [
   { path: 'login', component: LoginComponent },
   {path:'register',component:RegisterComponent},
   {path:'forgot',component:ForgotpasswordComponent},
   {path:'',component:HomeComponent},
];

@NgModule({
  imports: [
    AppRoutingModule,
    RouterModule.forRoot(routes)
  ],
  exports: [AppModule]
})
export class AppRoutingModule { }
