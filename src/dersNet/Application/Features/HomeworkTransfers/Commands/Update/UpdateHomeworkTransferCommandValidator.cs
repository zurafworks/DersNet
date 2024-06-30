using FluentValidation;

namespace Application.Features.HomeworkTransfers.Commands.Update;

public class UpdateHomeworkTransferCommandValidator : AbstractValidator<UpdateHomeworkTransferCommand>
{
    public UpdateHomeworkTransferCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.HomeworkId).NotEmpty();
        RuleFor(c => c.StudentId).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Attachment).NotEmpty();
        RuleFor(c => c.TransferDate).NotEmpty();
    }
}