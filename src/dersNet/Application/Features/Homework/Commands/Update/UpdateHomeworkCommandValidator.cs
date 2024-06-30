using FluentValidation;

namespace Application.Features.Homework.Commands.Update;

public class UpdateHomeworkCommandValidator : AbstractValidator<UpdateHomeworkCommand>
{
    public UpdateHomeworkCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.SessionId).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.UploadFile).NotEmpty();
        RuleFor(c => c.StartDate).NotEmpty();
        RuleFor(c => c.EndDate).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}