using FluentValidation;

namespace Application.Features.Sessions.Commands.Create;

public class CreateSessionCommandValidator : AbstractValidator<CreateSessionCommand>
{
    public CreateSessionCommandValidator()
    {
        RuleFor(c => c.CourseId).NotEmpty();
        RuleFor(c => c.Order).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.StartDate).NotEmpty();
        RuleFor(c => c.Link).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
    }
}