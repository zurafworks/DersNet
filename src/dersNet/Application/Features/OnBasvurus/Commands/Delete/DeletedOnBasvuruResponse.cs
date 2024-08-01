using NArchitecture.Core.Application.Responses;

namespace Application.Features.OnBasvurus.Commands.Delete;

public class DeletedOnBasvuruResponse : IResponse
{
    public Guid Id { get; set; }
}