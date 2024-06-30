using NArchitecture.Core.Application.Responses;

namespace Application.Features.Homework.Commands.Delete;

public class DeletedHomeworkResponse : IResponse
{
    public Guid Id { get; set; }
}