import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class AccountService {
    baseUrl='https://localhost:44334/';
    Card;
  constructor(private http:HttpClient) { }
  getRegisterValue(arr) {

    return this.http.post(this.baseUrl + 'Register', arr);
  }
  getLoginValue(arr) {

    return this.http.post(this.baseUrl + 'login', arr);
  }
  getForgotValue(arr) {
    return this.http.post(this.baseUrl + 'ForgotPassword', arr);
  }
  getCard(cards){
    this.Card = cards;
  }


}
