using AutoMapper;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;

public sealed class DeleteNoteMapper : Profile
{
    public DeleteNoteMapper()
    {
        CreateMap<DeleteNoteRequest, Note>();
        CreateMap<Note, DeleteNoteResponse>();
    }
}