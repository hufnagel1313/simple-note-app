using AutoMapper;
using MediatR;
using SimpleNotesApp.Application.Repositories;
using SimpleNotesApp.Domain.Entities;

namespace SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;

public sealed class DeleteNoteHandler : IRequestHandler<DeleteNoteRequest, DeleteNoteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly INoteRepository _noteRepository;
    private readonly IMapper _mapper;

    public DeleteNoteHandler(IUnitOfWork unitOfWork, INoteRepository noteRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _noteRepository = noteRepository;
        _mapper = mapper;
    }
    
    public async Task<DeleteNoteResponse> Handle(DeleteNoteRequest request, CancellationToken cancellationToken)
    {
        var note = await _noteRepository.Get(request.Id, cancellationToken);
        _noteRepository.Delete(note);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<DeleteNoteResponse>(note);
    }
}