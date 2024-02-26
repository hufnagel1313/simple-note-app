using AutoMapper;
using MediatR;
using SimpleNotesApp.Application.Features.NoteFeatures.GetAllNote;
using SimpleNotesApp.Application.Repositories;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.noteFeatures.GetAllNote;

public sealed class GetAllNoteHandler : IRequestHandler<GetAllNoteRequest, List<GetAllNoteResponse>>
{
    private readonly INoteRepository _noteRepository;
    private readonly IMapper _mapper;

    public GetAllNoteHandler(INoteRepository noteRepository, IMapper mapper)
    {
        _noteRepository = noteRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllNoteResponse>> Handle(GetAllNoteRequest request, CancellationToken cancellationToken)
    {
        List<Note> notes;
        if(request.Label.Equals("all"))
        {
            notes = await _noteRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllNoteResponse>>(notes);
        }
        notes = await _noteRepository.GetByLabel(request.Label, cancellationToken);
        return _mapper.Map<List<GetAllNoteResponse>>(notes);
    }
}