using NArchitecture.Core.Application.Responses;

namespace Application.Features.Sessions.Commands.Delete;

public class DeletedSessionResponse : IResponse
{
    public Guid Id { get; set; }
}