using FluentValidation;

namespace SimpleNotesApp.Application.Features.NoteFeatures.CreateNote;

public sealed class CreateNoteValidator : AbstractValidator<CreateNoteRequest>
{
    public CreateNoteValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(128);
        RuleFor(x => x.Content).NotEmpty().MaximumLength(2048);
        RuleFor(x => x.Label).NotEmpty();
    }
}