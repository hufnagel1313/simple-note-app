using AutoMapper;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.GetNote;

public sealed class GetNoteMapper : Profile
{
    public GetNoteMapper()
    {
        CreateMap<Note, GetNoteResponse>();
    }
}