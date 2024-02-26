import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NoteListComponent } from './components/notes/note-list/note-list.component';
import { NotesComponent } from './components/notes/notes.component';
import { NoteUpsertComponent } from './components/notes/note-upsert/note-upsert.component';

const routes: Routes = [
  {
    path: '', component: NotesComponent, children: [
      { path: '', component: NoteListComponent, pathMatch: 'full' },
      { path: 'notes/:label', component: NoteListComponent, pathMatch: 'full' },
      { path: 'note', component: NoteUpsertComponent, pathMatch: 'full' },
      { path: 'note/:id', component: NoteUpsertComponent, pathMatch: 'full' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }