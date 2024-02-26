namespace SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;

public sealed record DeleteNoteResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateDeleted { get; set; }
}