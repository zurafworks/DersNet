using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.GroupUsers.Commands.Create;

public class CreatedGroupUserResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid UserId { get; set; }
    public UserStatus Status { get; set; }
}