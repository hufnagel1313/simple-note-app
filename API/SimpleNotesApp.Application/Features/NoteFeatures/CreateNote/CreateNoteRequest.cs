using MediatR;

namespace SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;

public sealed record CreateNoteRequest(string Title, string Content, string Label) : IRequest<CreateNoteResponse>;