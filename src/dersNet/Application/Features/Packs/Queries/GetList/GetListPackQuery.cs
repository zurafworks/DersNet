using Application.Features.Packs.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Packs.Constants.PacksOperationClaims;

namespace Application.Features.Packs.Queries.GetList;

public class GetListPackQuery : IRequest<GetListResponse<GetListPackListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListPacks({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetPacks";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListPackQueryHandler : IRequestHandler<GetListPackQuery, GetListResponse<GetListPackListItemDto>>
    {
        private readonly IPackRepository _packRepository;
        private readonly IMapper _mapper;

        public GetListPackQueryHandler(IPackRepository packRepository, IMapper mapper)
        {
            _packRepository = packRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListPackListItemDto>> Handle(GetListPackQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Pack> packs = await _packRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListPackListItemDto> response = _mapper.Map<GetListResponse<GetListPackListItemDto>>(packs);
            return response;
        }
    }
}