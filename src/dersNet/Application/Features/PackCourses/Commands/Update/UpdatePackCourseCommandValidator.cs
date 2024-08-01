using FluentValidation;

namespace Application.Features.PackCourses.Commands.Update;

public class UpdatePackCourseCommandValidator : AbstractValidator<UpdatePackCourseCommand>
{
    public UpdatePackCourseCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.PackId).NotEmpty();
        RuleFor(c => c.CourseId).NotEmpty();
    }
}