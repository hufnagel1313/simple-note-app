using MediatR;

namespace SimpleNotesApp.Application.Features.NoteFeatures.GetAllNote;

public sealed record GetAllNoteRequest(string Label) : IRequest<List<GetAllNoteResponse>>;