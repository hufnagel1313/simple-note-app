import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NoteModel } from 'src/app/models/note.model';
import { NoteService } from 'src/app/services/note.service';

@Component({
  selector: 'app-note-list',
  templateUrl: './note-list.component.html',
  styleUrls: ['./note-list.component.css']
})
export class NoteListComponent {

  public notes: NoteModel[] = [];
  private label: string = 'all';

  constructor(private noteService: NoteService, private route: ActivatedRoute) {
    this.label = this.route.snapshot.params['label'];
    route.params.subscribe(val => {
      this.label = this.route.snapshot.params['label'];
      if (!this.label) this.label = 'all';
      this.getNoteList(this.label);
    });
  }

  async ngOnInit(): Promise<void> {
  }

  async getNoteList(label: string): Promise<void> {
    this.notes = await this.noteService.geList(label);
  }

  onNoteDeleted(id: string): void {
    console.log('Note deleted', id);
    this.notes = this.notes.filter(note => note.id !== id);
  }
}
