using FluentValidation;

namespace Application.Features.Groups.Commands.Update;

public class UpdateGroupCommandValidator : AbstractValidator<UpdateGroupCommand>
{
    public UpdateGroupCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
        RuleFor(c => c.Quota).NotEmpty();
        RuleFor(c => c.PackId).NotEmpty();
    }
}