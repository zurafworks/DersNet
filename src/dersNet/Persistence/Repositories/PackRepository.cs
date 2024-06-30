using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PackRepository : EfRepositoryBase<Pack, Guid, BaseDbContext>, IPackRepository
{
    public PackRepository(BaseDbContext context) : base(context)
    {
    }
}