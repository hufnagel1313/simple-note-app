using FluentValidation;

namespace SimpleNotesApp.Application.Features.NoteFeatures.DeleteNote;

public sealed class DeleteNoteValidator : AbstractValidator<DeleteNoteRequest>
{
    public DeleteNoteValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}