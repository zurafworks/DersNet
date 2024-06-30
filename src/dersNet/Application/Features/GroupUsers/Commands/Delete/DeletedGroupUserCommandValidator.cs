using FluentValidation;

namespace Application.Features.GroupUsers.Commands.Delete;

public class DeleteGroupUserCommandValidator : AbstractValidator<DeleteGroupUserCommand>
{
    public DeleteGroupUserCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}