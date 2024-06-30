using FluentValidation;

namespace Application.Features.HomeworkTransfers.Commands.Delete;

public class DeleteHomeworkTransferCommandValidator : AbstractValidator<DeleteHomeworkTransferCommand>
{
    public DeleteHomeworkTransferCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}