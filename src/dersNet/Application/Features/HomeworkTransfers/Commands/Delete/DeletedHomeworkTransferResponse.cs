using NArchitecture.Core.Application.Responses;

namespace Application.Features.HomeworkTransfers.Commands.Delete;

public class DeletedHomeworkTransferResponse : IResponse
{
    public Guid Id { get; set; }
}