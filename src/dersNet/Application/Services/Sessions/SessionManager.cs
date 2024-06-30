using Application.Features.Sessions.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Sessions;

public class SessionManager : ISessionService
{
    private readonly ISessionRepository _sessionRepository;
    private readonly SessionBusinessRules _sessionBusinessRules;

    public SessionManager(ISessionRepository sessionRepository, SessionBusinessRules sessionBusinessRules)
    {
        _sessionRepository = sessionRepository;
        _sessionBusinessRules = sessionBusinessRules;
    }

    public async Task<Session?> GetAsync(
        Expression<Func<Session, bool>> predicate,
        Func<IQueryable<Session>, IIncludableQueryable<Session, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Session? session = await _sessionRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return session;
    }

    public async Task<IPaginate<Session>?> GetListAsync(
        Expression<Func<Session, bool>>? predicate = null,
        Func<IQueryable<Session>, IOrderedQueryable<Session>>? orderBy = null,
        Func<IQueryable<Session>, IIncludableQueryable<Session, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Session> sessionList = await _sessionRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return sessionList;
    }

    public async Task<Session> AddAsync(Session session)
    {
        Session addedSession = await _sessionRepository.AddAsync(session);

        return addedSession;
    }

    public async Task<Session> UpdateAsync(Session session)
    {
        Session updatedSession = await _sessionRepository.UpdateAsync(session);

        return updatedSession;
    }

    public async Task<Session> DeleteAsync(Session session, bool permanent = false)
    {
        Session deletedSession = await _sessionRepository.DeleteAsync(session);

        return deletedSession;
    }
}
