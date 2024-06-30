using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.HomeworkTransfers.Commands.Create;

public class CreatedHomeworkTransferResponse : IResponse
{
    public Guid Id { get; set; }
    public int HomeworkId { get; set; }
    public int StudentId { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; }
    public DateTime TransferDate { get; set; }
}