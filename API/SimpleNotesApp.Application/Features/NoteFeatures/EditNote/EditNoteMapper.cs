using AutoMapper;

using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.EditNote;

public sealed class EditNoteMapper : Profile
{
    public EditNoteMapper()
    {
        CreateMap<EditNoteRequest, Note>();
        CreateMap<Note, EditNoteResponse>();
    }
}