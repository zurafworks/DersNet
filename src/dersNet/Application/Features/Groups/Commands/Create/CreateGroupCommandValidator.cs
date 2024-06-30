using FluentValidation;

namespace Application.Features.Groups.Commands.Create;

public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
{
    public CreateGroupCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
        RuleFor(c => c.Quota).NotEmpty();
        RuleFor(c => c.PackId).NotEmpty();
    }
}