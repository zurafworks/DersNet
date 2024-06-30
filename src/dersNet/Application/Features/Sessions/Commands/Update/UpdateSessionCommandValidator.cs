using FluentValidation;

namespace Application.Features.Sessions.Commands.Update;

public class UpdateSessionCommandValidator : AbstractValidator<UpdateSessionCommand>
{
    public UpdateSessionCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.CourseId).NotEmpty();
        RuleFor(c => c.Order).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.StartDate).NotEmpty();
        RuleFor(c => c.Link).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
    }
}