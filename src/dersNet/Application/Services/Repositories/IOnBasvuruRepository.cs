using Application.Features.OnBasvurus.Queries.GetById;
using Application.Features.OnBasvurus.Queries.GetListWithStrings;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IOnBasvuruRepository : IAsyncRepository<OnBasvuru, Guid>, IRepository<OnBasvuru, Guid>
{
    Task<IPaginate<GetListOnBasvuruWithStringsListItemDto>> GetListOnBasvuruWithStringsPaginateAsync(int index, int size, CancellationToken cancellationToken);
    Task<GetByIdOnBasvuruResponse> GetByIdOnBasvuruAsync(Guid id);
}