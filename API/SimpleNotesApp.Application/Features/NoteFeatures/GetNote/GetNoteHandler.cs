using AutoMapper;
using MediatR;
using SimpleNotesApp.Application.Repositories;

namespace SimpleNotesApp.Application.Features.NoteFeatures.GetNote;

public sealed class GetNoteHandler : IRequestHandler<GetNoteRequest, GetNoteResponse>
{
    private readonly INoteRepository _noteRepository;
    private readonly IMapper _mapper;

    public GetNoteHandler(INoteRepository noteRepository, IMapper mapper)
    {
        _noteRepository = noteRepository;
        _mapper = mapper;
    }
    
    public async Task<GetNoteResponse> Handle(GetNoteRequest request, CancellationToken cancellationToken)
    {
        var note = await _noteRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetNoteResponse>(note);
    }
}