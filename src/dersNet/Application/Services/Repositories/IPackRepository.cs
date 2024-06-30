using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IPackRepository : IAsyncRepository<Pack, Guid>, IRepository<Pack, Guid>
{
}