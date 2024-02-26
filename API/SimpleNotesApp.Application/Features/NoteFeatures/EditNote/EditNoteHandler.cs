using AutoMapper;
using MediatR;
using SimpleNotesApp.Application.Repositories;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.EditNote;

public sealed class EditNoteHandler : IRequestHandler<EditNoteRequest, EditNoteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly INoteRepository _noteRepository;
    private readonly IMapper _mapper;

    public EditNoteHandler(IUnitOfWork unitOfWork, INoteRepository noteRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _noteRepository = noteRepository;
        _mapper = mapper;
    }
    
    public async Task<EditNoteResponse> Handle(EditNoteRequest request, CancellationToken cancellationToken)
    {
        var note = _mapper.Map<Note>(request);
        _noteRepository.Update(note);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<EditNoteResponse>(note);
    }
}