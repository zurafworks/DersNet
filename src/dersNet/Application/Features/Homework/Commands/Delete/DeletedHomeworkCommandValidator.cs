using FluentValidation;

namespace Application.Features.Homework.Commands.Delete;

public class DeleteHomeworkCommandValidator : AbstractValidator<DeleteHomeworkCommand>
{
    public DeleteHomeworkCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}