import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { NoteService } from 'src/app/Services/note.service';
import { Note } from 'src/app/models/note.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  color: Note = new Note();
  param: any;
  labelNotes:any;
  gridView:any;
  allnotes:any;
  constructor(private router:Router,private noteobj:NoteService,private route: ActivatedRoute) { }

  ngOnInit() {
    this.getLabelNote();
    this.getNotes();
    

    this.route.queryParams.subscribe(params => {
      this.param = params['page'];
      this.gridView=  params['view'];
    });
  }

  getNotes(){
    this.noteobj.Getnote().subscribe(data => {
      console.log(data);
      this.allnotes=data;
     // console.log(data);
    });
      }

  getLabelNote()
  {
    this.noteobj.getlabel().subscribe(Response => {
      this.labelNotes=Response;
    })
  }

}
