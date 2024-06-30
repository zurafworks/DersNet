using FluentValidation;

namespace Application.Features.GroupUsers.Commands.Update;

public class UpdateGroupUserCommandValidator : AbstractValidator<UpdateGroupUserCommand>
{
    public UpdateGroupUserCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.GroupId).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
    }
}