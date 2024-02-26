using Microsoft.AspNetCore.Mvc;
using MediatR;
using SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;
using SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;
using SimpleNotesApp.Application.Features.NoteFeatures.EditNote;
using SimpleNotesApp.Application.Features.NoteFeatures.GetAllNote;
using SimpleNotesApp.Application.Features.NoteFeatures.GetNote;

namespace SimpleNotesApp.API.Controllers;

[ApiController]
[Route("note")]
public class NoteController : ControllerBase
{
    private readonly IMediator _mediator;

    public NoteController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetNoteResponse>> Get(Guid id, CancellationToken cancellationToken)
    {
        var request = new GetNoteRequest(id);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpGet("all/{label}")]
    public async Task<ActionResult<List<GetAllNoteResponse>>> GetAll(string label, CancellationToken cancellationToken)
    {
        var request = new GetAllNoteRequest(label);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreateNoteResponse>> Create(CreateNoteRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpPut]
    public async Task<ActionResult<CreateNoteResponse>> Update(EditNoteRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<DeleteNoteResponse>> Delete(Guid id, CancellationToken cancellationToken)
    {
        var request = new DeleteNoteRequest(id);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}