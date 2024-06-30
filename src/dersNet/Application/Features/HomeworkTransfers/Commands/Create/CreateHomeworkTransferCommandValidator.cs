using FluentValidation;

namespace Application.Features.HomeworkTransfers.Commands.Create;

public class CreateHomeworkTransferCommandValidator : AbstractValidator<CreateHomeworkTransferCommand>
{
    public CreateHomeworkTransferCommandValidator()
    {
        RuleFor(c => c.HomeworkId).NotEmpty();
        RuleFor(c => c.StudentId).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Attachment).NotEmpty();
        RuleFor(c => c.TransferDate).NotEmpty();
    }
}