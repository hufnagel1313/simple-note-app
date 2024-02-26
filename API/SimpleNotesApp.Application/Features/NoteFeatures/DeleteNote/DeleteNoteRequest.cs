using MediatR;

namespace SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;

public sealed record DeleteNoteRequest(Guid Id) : IRequest<DeleteNoteResponse>;