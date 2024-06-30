using FluentValidation;

namespace Application.Features.Sessions.Commands.Delete;

public class DeleteSessionCommandValidator : AbstractValidator<DeleteSessionCommand>
{
    public DeleteSessionCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}