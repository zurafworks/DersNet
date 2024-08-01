using FluentValidation;

namespace Application.Features.OnBasvurus.Commands.Delete;

public class DeleteOnBasvuruCommandValidator : AbstractValidator<DeleteOnBasvuruCommand>
{
    public DeleteOnBasvuruCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}