import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { NoteListComponent } from './components/notes/note-list/note-list.component';
import { NoteUpsertComponent } from './components/notes/note-upsert/note-upsert.component';
import { NoteDetailComponent } from './components/notes/note-detail/note-detail.component';
import { NoteMenuComponent } from './components/notes/note-menu/note-menu.component';
import { NoteListItemComponent } from './components/notes/note-list-item/note-list-item.component';
import { NotesComponent } from './components/notes/notes.component';
import { HttpClientModule } from '@angular/common/http';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    NoteListComponent,
    NoteUpsertComponent,
    NoteDetailComponent,
    NoteMenuComponent,
    NoteListItemComponent,
    NotesComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    FontAwesomeModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
