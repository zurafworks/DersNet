using Application.Features.Packs.Queries.GetList;
using Application.Features.Questions.Queries.GetListWithChoices;
using Application.Services.Repositories;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Newtonsoft.Json;
using Persistence.Contexts;
using System.Linq.Expressions;
using System.Linq;

namespace Persistence.Repositories;

public class PackRepository : EfRepositoryBase<Pack, Guid, BaseDbContext>, IPackRepository
{
    public PackRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<IPaginate<GetListPackListItemDto>> GetListPacksWithStringsPaginateAsync(int index, int size, CancellationToken cancellationToken, Expression<Func<Pack, bool>> predicate, string? groupFieldJson = null)
    {
        //var query = from pack in Context.Packs.Where(predicate)
        //            select new GetListPackListItemDto
        //            {
        //                Id = pack.Id,
        //                Title = pack.Title,
        //                Description = pack.Description,
        //                Price = pack.Price,
        //                PriceCurrency = pack.PriceCurrency,
        //                PriceCurrencyStr = pack.PriceCurrency.ToString(),
        //                TaxRate = pack.TaxRate
        //            };
        //return await query.ToPaginateAsync(index, size, cancellationToken: cancellationToken);

        var query = Context.Packs.AsQueryable();

        // Filtre uygulama
        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        // Eðer grup alaný varsa
        //if (!string.IsNullOrEmpty(groupFieldJson))
        if (false)
        {
            // JSON'dan gruplama bilgilerini ayrýþtýr
            var groupingInfos = JsonConvert.DeserializeObject<List<GroupingInfo>>(groupFieldJson);

            //Gruplama
            var groupedQuery = query.AsEnumerable()
                .GroupBy(pack => new
                {
                    GroupKey = groupingInfos.Select(gi => gi.Selector)
                })
                .Select(g => new
                {
                    GroupKey = g.Key,
                    Items = g.Select(p => new GetListPackListItemDto
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Description = p.Description,
                        Price = p.Price,
                        PriceCurrency = p.PriceCurrency,
                        PriceCurrencyStr = p.PriceCurrency.ToString(),
                        TaxRate = p.TaxRate
                    }).ToList()
                }).AsQueryable();



            // Gruplarý sayfalama
            var totalCount = await groupedQuery.GroupBy(x => x.GroupKey).CountAsync(cancellationToken);
            var paginatedGroups = await groupedQuery.Skip((index - 1) * size).Take(size).AsQueryable().ToListAsync(cancellationToken);

            // Gruplarýn içindeki öðeleri düz liste haline getir ve sayfalamayý uygula
            var items = paginatedGroups.SelectMany(g => g.Items).ToList();
            return await items.AsQueryable().ToPaginateAsync(index, size, cancellationToken: cancellationToken);
        }
        else
        {
            return await query.Select(p => new GetListPackListItemDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Price = p.Price,
                PriceCurrency = p.PriceCurrency,
                PriceCurrencyStr = p.PriceCurrency.ToString(),
                TaxRate = p.TaxRate
            }).ToPaginateAsync(index, size, cancellationToken: cancellationToken);
        }
    }

    public class GroupingInfo
    {
        public string Selector { get; set; }
        public bool Desc { get; set; }
        public bool IsExpanded { get; set; }
    }
}