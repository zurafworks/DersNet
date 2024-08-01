using FluentValidation;

namespace Application.Features.PackCourses.Commands.Delete;

public class DeletePackCourseCommandValidator : AbstractValidator<DeletePackCourseCommand>
{
    public DeletePackCourseCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}