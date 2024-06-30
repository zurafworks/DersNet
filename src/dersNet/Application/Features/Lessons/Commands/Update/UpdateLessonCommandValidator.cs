using FluentValidation;

namespace Application.Features.Lessons.Commands.Update;

public class UpdateLessonCommandValidator : AbstractValidator<UpdateLessonCommand>
{
    public UpdateLessonCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
        RuleFor(c => c.Depth).NotEmpty();
        RuleFor(c => c.Order).NotEmpty();
    }
}