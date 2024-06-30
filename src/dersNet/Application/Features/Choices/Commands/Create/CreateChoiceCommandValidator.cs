using FluentValidation;

namespace Application.Features.Choices.Commands.Create;

public class CreateChoiceCommandValidator : AbstractValidator<CreateChoiceCommand>
{
    public CreateChoiceCommandValidator()
    {
        RuleFor(c => c.QuestionId).NotEmpty();
        RuleFor(c => c.Text).NotEmpty();
        RuleFor(c => c.Image).NotEmpty();
        RuleFor(c => c.IsAnswer).NotEmpty();
    }
}