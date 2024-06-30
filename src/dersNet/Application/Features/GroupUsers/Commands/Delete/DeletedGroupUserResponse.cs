using NArchitecture.Core.Application.Responses;

namespace Application.Features.GroupUsers.Commands.Delete;

public class DeletedGroupUserResponse : IResponse
{
    public Guid Id { get; set; }
}