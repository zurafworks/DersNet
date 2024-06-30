using FluentValidation;

namespace Application.Features.Lessons.Commands.Create;

public class CreateLessonCommandValidator : AbstractValidator<CreateLessonCommand>
{
    public CreateLessonCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
        RuleFor(c => c.Depth).NotEmpty();
        RuleFor(c => c.Order).NotEmpty();
    }
}