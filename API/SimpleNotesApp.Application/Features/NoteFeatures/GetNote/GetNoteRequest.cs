using MediatR;

namespace SimpleNotesApp.Application.Features.NoteFeatures.GetNote;

public sealed record GetNoteRequest(Guid Id) : IRequest<GetNoteResponse>;