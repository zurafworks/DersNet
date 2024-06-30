using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Sessions;

public interface ISessionService
{
    Task<Session?> GetAsync(
        Expression<Func<Session, bool>> predicate,
        Func<IQueryable<Session>, IIncludableQueryable<Session, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Session>?> GetListAsync(
        Expression<Func<Session, bool>>? predicate = null,
        Func<IQueryable<Session>, IOrderedQueryable<Session>>? orderBy = null,
        Func<IQueryable<Session>, IIncludableQueryable<Session, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Session> AddAsync(Session session);
    Task<Session> UpdateAsync(Session session);
    Task<Session> DeleteAsync(Session session, bool permanent = false);
}
