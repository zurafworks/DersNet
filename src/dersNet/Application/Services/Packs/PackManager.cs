using Application.Features.Packs.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Packs;

public class PackManager : IPackService
{
    private readonly IPackRepository _packRepository;
    private readonly PackBusinessRules _packBusinessRules;

    public PackManager(IPackRepository packRepository, PackBusinessRules packBusinessRules)
    {
        _packRepository = packRepository;
        _packBusinessRules = packBusinessRules;
    }

    public async Task<Pack?> GetAsync(
        Expression<Func<Pack, bool>> predicate,
        Func<IQueryable<Pack>, IIncludableQueryable<Pack, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Pack? pack = await _packRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return pack;
    }

    public async Task<IPaginate<Pack>?> GetListAsync(
        Expression<Func<Pack, bool>>? predicate = null,
        Func<IQueryable<Pack>, IOrderedQueryable<Pack>>? orderBy = null,
        Func<IQueryable<Pack>, IIncludableQueryable<Pack, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Pack> packList = await _packRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return packList;
    }

    public async Task<Pack> AddAsync(Pack pack)
    {
        Pack addedPack = await _packRepository.AddAsync(pack);

        return addedPack;
    }

    public async Task<Pack> UpdateAsync(Pack pack)
    {
        Pack updatedPack = await _packRepository.UpdateAsync(pack);

        return updatedPack;
    }

    public async Task<Pack> DeleteAsync(Pack pack, bool permanent = false)
    {
        Pack deletedPack = await _packRepository.DeleteAsync(pack);

        return deletedPack;
    }
}
