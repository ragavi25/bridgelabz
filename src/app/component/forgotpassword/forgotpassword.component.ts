import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forgotpassword',
  templateUrl: './forgotpassword.component.html',
  styleUrls: ['./forgotpassword.component.scss']
})
export class ForgotpasswordComponent implements OnInit {
  email = new FormControl('', [
    Validators.required, Validators.email,Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$'), ]);

  constructor(private serviceobj:AccountService,private router:Router) { }

  ngOnInit() {
  }
  onForgot() {
    const data = {
      email: this.email.value,
    };
    console.log(data);
    this.serviceobj.getForgotValue(data).subscribe((result) => {
      const temp = JSON.stringify(result);
      const results = JSON.parse(temp);
      this.router.navigate(['/home']);
    });
    this.serviceobj.getForgotValue(data);
  }
}


