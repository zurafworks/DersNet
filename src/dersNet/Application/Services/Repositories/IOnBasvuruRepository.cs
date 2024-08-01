using Application.Features.OnBasvurus.Queries.GetById;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IOnBasvuruRepository : IAsyncRepository<OnBasvuru, Guid>, IRepository<OnBasvuru, Guid>
{
    Task<GetByIdOnBasvuruResponse> GetByIdOnBasvuruAsync(Guid id);
}