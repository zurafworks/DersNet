using FluentValidation;

namespace Application.Features.Homework.Commands.Create;

public class CreateHomeworkCommandValidator : AbstractValidator<CreateHomeworkCommand>
{
    public CreateHomeworkCommandValidator()
    {
        RuleFor(c => c.SessionId).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.UploadFile).NotEmpty();
        RuleFor(c => c.StartDate).NotEmpty();
        RuleFor(c => c.EndDate).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}