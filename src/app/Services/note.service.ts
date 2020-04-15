import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Title } from '@angular/platform-browser';
import { Identifiers } from '@angular/compiler';
import { DatasharingService } from './datasharing.service';

@Injectable({
  providedIn: 'root'
})
export class NoteService {
  baseUrl = 'https://localhost:44334/';
  constructor(private http: HttpClient) { }
  AddNote(data) {
    return this.http.post(this.baseUrl + 'AddNote', data);
  }
  Ispin(id) {
    return this.http.put(this.baseUrl + 'Ispin?id='+ id, id);
  }
  getpin() {
    return this.http.get(this.baseUrl + 'Getpin');
  }
  Unpin(id) {
    return this.http.put(this.baseUrl + 'Unpin?id='+ id, id);
  }
  getunpin() {
    return this.http.get(this.baseUrl + 'Getunpin');
  }
  archive(id) {
    return this.http.put(this.baseUrl + 'IsArchive?id='+ id, id);
  }
  removereminder(id) {
    return this.http.put(this.baseUrl + 'removereminder?id='+ id,id);
  }
  getnote(id) {
    return this.http.get(this.baseUrl + 'getid?id='+ id);
  }
  getbin() {
    return this.http.get(this.baseUrl + 'GetBin');
  }
  emptybin(id) {
    return this.http.post(this.baseUrl + 'Isbin?id='+ id, id);
  }
  deleteforever(id) {
    return this.http.delete(this.baseUrl + 'DeleteForeve?id='+ id, null);
  }
  restore(id) {
    return this.http.post(this.baseUrl + 'Restore?id='+ id, id);
  }
  UpdateNote(data) {

    return this.http.put(this.baseUrl + 'Update', data);
  }
  Getnote() {
    return this.http.get(this.baseUrl + 'get');
  }
  IsArchive(id) {
    return this.http.put(this.baseUrl + 'IsArchive?id='+ id, id);
  }
  deletelabel(id) {
    return this.http.delete(this.baseUrl + 'Deletelabel?id='+ id);
  }
  Reminder(date,id) {
    return this.http.post(this.baseUrl + 'Reminder?id='+ id +'&Reminder='+ date, null);
  }
  updateLabel(id, newLabel) {
    const params = {
      "Id": id,
      "name": newLabel
    };
    return this.http.put(this.baseUrl + 'updatelabel', null);
  }
  UploadImage(id, img) {
    return this.http.put(this.baseUrl + 'UploadImage', null);
  }
  getlabel() {
    return this.http.get(this.baseUrl + 'getlabel');
  }
  getlabelid(arr){
    return this.http.get(this.baseUrl+'getlabelid?id='+ arr);
  }
  addcolor(id) {
    //debugger;
    return this.http.post(this.baseUrl + 'ChangeColor', id);
  }
  deletenote(id) {
    debugger;
    return this.http.delete(this.baseUrl + 'delete?id='+ id,null);
  }
  addlabel(id,name,userid) {
    
    return this.http.post(this.baseUrl + 'AddLabel?id='+id + '&name=' + name +'&userid='+ userid, null);
  }
  color(id,changeColor) {
    debugger;
//    const url =environment.Url +'api/color?id='+ id +'&color='+ value;   

    return this.http.put(this.baseUrl +'ChangeColor?id='+ id +'&color='+ changeColor,null);
  }
  GetArchive() {
    return this.http.get(this.baseUrl + 'GetArchive');
  }
  isarchive(id) {
    return this.http.put(this.baseUrl + 'IsArchive?id='+ id, null);
  }
  unarchive(id) {
    return this.http.put(this.baseUrl + 'UnArchive?id=' + id, id);
  }
  getReminder() {
    return this.http.get(this.baseUrl + 'GetReminder');
  }
  addImage(id, file: any) {
    let input = new FormData();
    input.append("image", file);

    return this.http.put(this.baseUrl + 'addimage?id='+ id, input);
  }
  addCollaborator(id,email,recemail) {
    debugger;
    return this.http.post(this.baseUrl + 'AddCollaborator?id='+ id + '&senderemail='+ email + '&receiveemail=' + recemail,null);
  }
  getCollaborators() {
    return this.http.get(this.baseUrl + 'GetCollaborator');
  }
  deleteCollaborator(id) {
    return this.http.delete(this.baseUrl + 'DeleteCollaborator?id=' + id);
  }
}

