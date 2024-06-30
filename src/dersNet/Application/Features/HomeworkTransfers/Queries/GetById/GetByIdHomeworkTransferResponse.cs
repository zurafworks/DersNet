using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.HomeworkTransfers.Queries.GetById;

public class GetByIdHomeworkTransferResponse : IResponse
{
    public Guid Id { get; set; }
    public int HomeworkId { get; set; }
    public int StudentId { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; }
    public DateTime TransferDate { get; set; }
}