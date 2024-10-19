using Application.Features.Packs.Queries.GetList;
using Application.Features.Questions.Queries.GetListWithChoices;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IPackRepository : IAsyncRepository<Pack, Guid>, IRepository<Pack, Guid>
{

    Task<IPaginate<GetListPackListItemDto>> GetListPacksWithStringsPaginateAsync(int index, int size, CancellationToken cancellationToken, Expression<Func<Pack, bool>> predicate, string? groupFieldJson);
}