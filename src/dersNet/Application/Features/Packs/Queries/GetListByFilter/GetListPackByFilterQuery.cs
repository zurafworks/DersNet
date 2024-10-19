using Application.Features.Packs.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System.Linq.Expressions;
using static Application.Features.Packs.Constants.PacksOperationClaims;

namespace Application.Features.Packs.Queries.GetListByFilter;
public class GetListPackByFilterQuery : IRequest<GetListResponse<GetListPackListItemDto>>/*, ISecuredRequest*//*, ICachableRequest*/
{
    //public PageRequest PageRequest { get; set; }

    public GetListByFilterQueryDto Request { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListPacks({Request.PageIndex},{Request.PageSize})";
    public string? CacheGroupKey => "GetPacks";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListPackByFilterQueryHandler : IRequestHandler<GetListPackByFilterQuery, GetListResponse<GetListPackListItemDto>>
    {
        private readonly IPackRepository _packRepository;
        private readonly IMapper _mapper;
        private readonly FilterHelper _filterHelper;

        public GetListPackByFilterQueryHandler(IPackRepository packRepository, IMapper mapper, FilterHelper filterHelper)
        {
            _packRepository = packRepository;
            _mapper = mapper;
            _filterHelper = filterHelper;
        }

        public async Task<GetListResponse<GetListPackListItemDto>> Handle(GetListPackByFilterQuery request, CancellationToken cancellationToken)
        {

            //Filtreleme
            Expression<Func<Pack, bool>> predicate = x => true;
            if (!request.Request.Filter.IsNullOrEmpty())
                predicate = _filterHelper.GetExpression<Pack>(request.Request.Filter);

            //Gruplama
            IQueryable<Pack> packsQuery = _packRepository.Query();

            if (!string.IsNullOrEmpty(request.Request.Group))
            {
                var groupField = request.Request.Group; // Grup alanını al

                // Gruplama için gerekli işlemi yap
                packsQuery = packsQuery.GroupBy(p => EF.Property<object>(p, groupField)) // Dinamik grup alanı
                                         .Select(g => g.FirstOrDefault()); // Gruplardan bir tane al (örneğin)
            }

            IPaginate<GetListPackListItemDto> packs = await _packRepository.
                GetListPacksWithStringsPaginateAsync(
                index: request.Request.PageIndex,
                size: request.Request.PageSize,
                cancellationToken: cancellationToken,
                predicate: predicate,
        groupFieldJson: request.Request.Group
            );
            GetListResponse<GetListPackListItemDto> response = _mapper.Map<GetListResponse<GetListPackListItemDto>>(packs);
            return response;
        }
    }
}
