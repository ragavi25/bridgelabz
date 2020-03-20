import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  email = new FormControl('', [
    Validators.required, Validators.email, ]);
  password = new FormControl('', [
    Validators.required, Validators.minLength(6), ]);

  constructor(private serviceobj:AccountService,private router:Router) { }

  ngOnInit() {
  }
  onLogin() {
    const data = {
      password: this.password.value,
      email: this.email.value,
    };
    console.log(data);
    this.serviceobj.getLoginValue(data).subscribe((result) => {
      const temp = JSON.stringify(result);
      const results = JSON.parse(temp);
      
      this.router.navigate(['/home']);
    });
    this.serviceobj.getLoginValue(data);
  }
}


