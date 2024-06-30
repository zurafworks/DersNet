using NArchitecture.Core.Application.Responses;

namespace Application.Features.Packs.Commands.Delete;

public class DeletedPackResponse : IResponse
{
    public Guid Id { get; set; }
}