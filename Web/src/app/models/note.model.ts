export interface NoteModel {
    id: string,
    title: string,
    content: string,
    label: 'business' | 'social' | 'important',
    dateCreated?: Date
}