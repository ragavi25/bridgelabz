import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  
  hide = true;
  constructor(private serviceObject: AccountService, private router: Router) { }

  firstName = new FormControl('', [
    Validators.required, Validators.minLength(4), Validators.pattern('^[a-zA-Z]*'), ]);
  lastName = new FormControl('', [
    Validators.required, Validators.minLength(4), Validators.pattern('^[a-zA-Z]*'), ]);
  email = new FormControl('', [
    Validators.required, Validators.email,Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$'), ]);
  password = new FormControl('', [
    Validators.required, Validators.minLength(6), ]);
  ngOnInit() {
  }
  onRegistrationForm() {
    const data = {
      firstName: this.firstName.value,
      lastName: this.lastName.value,
      email: this.email.value,
      password: this.password.value,
    };
    console.log(data);
    this.serviceObject.getRegisterValue(data).subscribe((result) => {
      const temp = JSON.stringify(result);
      const results = JSON.parse(temp);
      this.router.navigate(['/login']);
    });
    this.serviceObject.getRegisterValue(data);
  }
  
}
