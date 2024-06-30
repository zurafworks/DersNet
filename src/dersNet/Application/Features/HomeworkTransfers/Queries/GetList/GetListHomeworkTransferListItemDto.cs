using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.HomeworkTransfers.Queries.GetList;

public class GetListHomeworkTransferListItemDto : IDto
{
    public Guid Id { get; set; }
    public int HomeworkId { get; set; }
    public int StudentId { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; }
    public DateTime TransferDate { get; set; }
}