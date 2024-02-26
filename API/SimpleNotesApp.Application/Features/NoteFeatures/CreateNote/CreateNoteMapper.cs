using AutoMapper;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;

public sealed class CreateNoteMapper : Profile
{
    public CreateNoteMapper()
    {
        CreateMap<CreateNoteRequest, Note>();
        CreateMap<Note, CreateNoteResponse>();
    }
}