namespace SimpleNotesApp.Application.Features.NoteFeatures.GetAllNote;

public sealed record GetAllNoteResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Label { get; set; }
    public DateTimeOffset DateCreated { get; set; }
}