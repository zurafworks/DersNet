using FluentValidation;

namespace Application.Features.GroupUsers.Commands.Create;

public class CreateGroupUserCommandValidator : AbstractValidator<CreateGroupUserCommand>
{
    public CreateGroupUserCommandValidator()
    {
        RuleFor(c => c.GroupId).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
    }
}