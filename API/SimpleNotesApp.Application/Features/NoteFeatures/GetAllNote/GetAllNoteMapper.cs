using AutoMapper;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.GetAllNote;

public sealed class GetAllNoteMapper : Profile
{
    public GetAllNoteMapper()
    {
        CreateMap<Note, GetAllNoteResponse>();
    }
}