import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Title } from '@angular/platform-browser';

@Injectable({
  providedIn: 'root'
})
export class NoteService {
  baseUrl='https://localhost:44334/';
  constructor(private http:HttpClient) { }
  AddNote(title,description,email)
  {
    const data={
      Title:title,
      Description:description,
      Email:email,
    };
    return this.http.post(this.baseUrl+'AddNote',data);
    
  }
}
