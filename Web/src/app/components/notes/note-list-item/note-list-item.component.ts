import { Component, EventEmitter, Input, Output } from '@angular/core';
import { NoteModel } from 'src/app/models/note.model';
import { NoteService } from 'src/app/services/note.service';
import { faTrash, faEdit } from '@fortawesome/free-solid-svg-icons';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';

@Component({
  selector: 'app-note-list-item',
  templateUrl: './note-list-item.component.html',
  styleUrls: ['./note-list-item.component.css']
})
export class NoteListItemComponent {

  @Input() note: NoteModel | undefined;
  @Output() deleteNote: EventEmitter<string> = new EventEmitter<string>();

  public faTrash = faTrash;
  public faEdit = faEdit;

  constructor(private noteService: NoteService, private router: Router) { }

  async ngOnInit(): Promise<void> {
  }

  edit(id: string): void {
    this.router.navigate(['note', id]);
  }

  async delete(id: string): Promise<void> {
    Swal.fire({
      title: 'Are you sure?',
      text: 'You will not be able to recover this note!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'No, keep it'
    }).then(async (result) => {
      if (result.isConfirmed) {
        await this.noteService.delete(id);
        this.deleteNote.emit(id);
        Swal.fire('Deleted!', 'Your note has been deleted.', 'success');
      }
    });
  }
}
