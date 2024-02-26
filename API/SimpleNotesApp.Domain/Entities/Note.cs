using SimpleNotesApp.Domain.Common;

namespace SimpleNotesApp.Domain.Entities;

public class Note: BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Label { get; set; }
}