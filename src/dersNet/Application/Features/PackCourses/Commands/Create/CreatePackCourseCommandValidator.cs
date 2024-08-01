using FluentValidation;

namespace Application.Features.PackCourses.Commands.Create;

public class CreatePackCourseCommandValidator : AbstractValidator<CreatePackCourseCommand>
{
    public CreatePackCourseCommandValidator()
    {
        RuleFor(c => c.PackId).NotEmpty();
        RuleFor(c => c.CourseId).NotEmpty();
    }
}