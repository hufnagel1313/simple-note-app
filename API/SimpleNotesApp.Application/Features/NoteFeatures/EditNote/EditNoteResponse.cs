namespace SimpleNotesApp.Application.Features.NoteFeatures.EditNote;

public sealed record EditNoteResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateUpdated { get; set; }
}