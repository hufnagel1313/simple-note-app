using AutoMapper;
using MediatR;
using SimpleNotesApp.Application.Repositories;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;

public sealed class CreateNoteHandler : IRequestHandler<CreateNoteRequest, CreateNoteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly INoteRepository _noteRepository;
    private readonly IMapper _mapper;

    public CreateNoteHandler(IUnitOfWork unitOfWork, INoteRepository noteRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _noteRepository = noteRepository;
        _mapper = mapper;
    }
    
    public async Task<CreateNoteResponse> Handle(CreateNoteRequest request, CancellationToken cancellationToken)
    {
        var note = _mapper.Map<Note>(request);
        _noteRepository.Create(note);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateNoteResponse>(note);
    }
}