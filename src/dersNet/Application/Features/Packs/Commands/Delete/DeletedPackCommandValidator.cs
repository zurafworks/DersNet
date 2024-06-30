using FluentValidation;

namespace Application.Features.Packs.Commands.Delete;

public class DeletePackCommandValidator : AbstractValidator<DeletePackCommand>
{
    public DeletePackCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}