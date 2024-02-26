import { Component, ViewChild } from '@angular/core';
import { NoteService } from 'src/app/services/note.service';
import { ActivatedRoute, Router } from '@angular/router';
import { NoteModel } from 'src/app/models/note.model';
import Swal from 'sweetalert2';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-note-upsert',
  templateUrl: './note-upsert.component.html',
  styleUrls: ['./note-upsert.component.css']
})
export class NoteUpsertComponent {

  @ViewChild('noteForm') noteForm!: NgForm;

  public model: NoteModel = {
    id: '',
    title: '',
    content: '',
    dateCreated: undefined,
    label: 'business',
  };

  constructor(
    private noteService: NoteService,
    private router: Router,
    private route: ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    const noteId = this.route.snapshot.paramMap.get('id');
    if (noteId) {
      this.get(noteId);
    }
  }

  public async get(id: string): Promise<void> {
    this.model = await this.noteService.get(id);
  }

  public async save(): Promise<void> {
    if (!this.noteForm.form.valid) {
      this.noteForm.form.markAllAsTouched();
      return;
    }

    if (this.model?.id) {
      await this.noteService.update(this.model);
      Swal.fire({
        title: "Updated",
        text: "Note updated successfully",
        icon: "success"
      }).then(() => {
        this.router.navigate([""]);
        return;
      });
    } else {
      await this.noteService.create(this.model!);
      Swal.fire({
        title: "Created",
        text: "Note created successfully",
        icon: "success"
      }).then(() => {
        this.router.navigate([""]);
        return;
      });;
    }

    return;
  }

  cancel(): void {
    this.router.navigate([""]);
    return;
  }

}
