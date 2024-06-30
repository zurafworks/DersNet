using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class SessionRepository : EfRepositoryBase<Session, Guid, BaseDbContext>, ISessionRepository
{
    public SessionRepository(BaseDbContext context) : base(context)
    {
    }
}