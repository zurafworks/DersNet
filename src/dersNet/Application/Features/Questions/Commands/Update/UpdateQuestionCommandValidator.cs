using FluentValidation;

namespace Application.Features.Questions.Commands.Update;

public class UpdateQuestionCommandValidator : AbstractValidator<UpdateQuestionCommand>
{
    public UpdateQuestionCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
        RuleFor(c => c.Text).NotEmpty();
        RuleFor(c => c.Image).NotEmpty();
    }
}