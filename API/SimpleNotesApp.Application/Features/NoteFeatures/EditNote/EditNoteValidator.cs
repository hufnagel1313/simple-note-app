using FluentValidation;

namespace SimpleNotesApp.Application.Features.NoteFeatures.EditNote;

public sealed class EditNoteValidator : AbstractValidator<EditNoteRequest>
{
    public EditNoteValidator()
    {
        RuleFor(x=> x.Id).NotEmpty();
        RuleFor(x => x.Title).NotEmpty().MaximumLength(128);
        RuleFor(x => x.Content).NotEmpty().MaximumLength(2048);
        RuleFor(x => x.Label).NotEmpty();
    }
}