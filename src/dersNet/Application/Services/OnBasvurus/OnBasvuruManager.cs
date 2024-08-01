using Application.Features.OnBasvurus.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.OnBasvurus;

public class OnBasvuruManager : IOnBasvuruService
{
    private readonly IOnBasvuruRepository _onBasvuruRepository;
    private readonly OnBasvuruBusinessRules _onBasvuruBusinessRules;

    public OnBasvuruManager(IOnBasvuruRepository onBasvuruRepository, OnBasvuruBusinessRules onBasvuruBusinessRules)
    {
        _onBasvuruRepository = onBasvuruRepository;
        _onBasvuruBusinessRules = onBasvuruBusinessRules;
    }

    public async Task<OnBasvuru?> GetAsync(
        Expression<Func<OnBasvuru, bool>> predicate,
        Func<IQueryable<OnBasvuru>, IIncludableQueryable<OnBasvuru, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        OnBasvuru? onBasvuru = await _onBasvuruRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return onBasvuru;
    }

    public async Task<IPaginate<OnBasvuru>?> GetListAsync(
        Expression<Func<OnBasvuru, bool>>? predicate = null,
        Func<IQueryable<OnBasvuru>, IOrderedQueryable<OnBasvuru>>? orderBy = null,
        Func<IQueryable<OnBasvuru>, IIncludableQueryable<OnBasvuru, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<OnBasvuru> onBasvuruList = await _onBasvuruRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return onBasvuruList;
    }

    public async Task<OnBasvuru> AddAsync(OnBasvuru onBasvuru)
    {
        OnBasvuru addedOnBasvuru = await _onBasvuruRepository.AddAsync(onBasvuru);

        return addedOnBasvuru;
    }

    public async Task<OnBasvuru> UpdateAsync(OnBasvuru onBasvuru)
    {
        OnBasvuru updatedOnBasvuru = await _onBasvuruRepository.UpdateAsync(onBasvuru);

        return updatedOnBasvuru;
    }

    public async Task<OnBasvuru> DeleteAsync(OnBasvuru onBasvuru, bool permanent = false)
    {
        OnBasvuru deletedOnBasvuru = await _onBasvuruRepository.DeleteAsync(onBasvuru);

        return deletedOnBasvuru;
    }
}
