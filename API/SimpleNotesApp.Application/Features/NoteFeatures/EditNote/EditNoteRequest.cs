using MediatR;

namespace SimpleNotesApp.Application.Features.NoteFeatures.EditNote;

public sealed record EditNoteRequest(Guid Id, string Title, string Content, string Label, DateTimeOffset DateCreated) : IRequest<EditNoteResponse>;