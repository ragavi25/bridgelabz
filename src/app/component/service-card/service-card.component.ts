import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-service-card',
  templateUrl: './service-card.component.html',
  styleUrls: ['./service-card.component.scss']
})
export class ServiceCardComponent implements OnInit {

  basic;
  selected;
  constructor(private serviceobj:AccountService,private router:Router) { }

  ngOnInit() {
  }
  basicCard()
  {
    this.selected=!this.selected;
    this.basic="Basic Card"; 
    this.router.navigate(['/login']);
  }
  advanceCard()
  {
    this.selected=!this.selected;
    this.basic="Advance Card";
  }
  next()
  {
   // this.serviceobj.Card(this.basic);
    this.router.navigate(['/register']);
  }

}
