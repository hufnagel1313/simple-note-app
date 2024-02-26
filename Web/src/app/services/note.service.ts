import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { NoteModel } from '../models/note.model';

@Injectable({
  providedIn: 'root'
})
export class NoteService {

  constructor(private api: ApiService) { }

  public async geList(label: string): Promise<NoteModel[]> {
    const request = this.api.get<NoteModel[]>(`/note/all/${label}`);
    return await this.api.getData<NoteModel[]>(request);
  }

  public async get(id: string): Promise<NoteModel> {
    const request = this.api.get<NoteModel>(`/note/${id}`);
    return await this.api.getData<NoteModel>(request);
  }

  public async delete(id: string): Promise<NoteModel> {
    const request = this.api.delete<NoteModel>(`/note/${id}`, {});
    return await this.api.getData<NoteModel>(request);
  }

  public async update(note: NoteModel): Promise<NoteModel> {
    const request = this.api.put<NoteModel>('/note/', note);
    return await this.api.getData<NoteModel>(request);
  }

  public async create(note: NoteModel): Promise<NoteModel> {
    const request = this.api.post<NoteModel>('/note/', note);
    return await this.api.getData<NoteModel>(request);
  }
}
