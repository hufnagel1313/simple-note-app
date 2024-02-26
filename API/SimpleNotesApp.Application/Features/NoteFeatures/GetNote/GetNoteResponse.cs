namespace SimpleNotesApp.Application.Features.NoteFeatures.GetNote;

public sealed record GetNoteResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Label { get; set; }
    public DateTimeOffset DateCreated { get; set; }
}