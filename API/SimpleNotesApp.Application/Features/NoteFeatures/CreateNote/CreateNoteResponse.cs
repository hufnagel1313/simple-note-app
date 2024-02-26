namespace SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;

public sealed record CreateNoteResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Label { get; set; }
}