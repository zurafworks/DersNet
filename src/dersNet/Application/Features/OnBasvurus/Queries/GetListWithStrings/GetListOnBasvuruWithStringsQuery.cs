using Application.Features.OnBasvurus.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.OnBasvurus.Constants.OnBasvurusOperationClaims;
using Application.Features.OnBasvurus.Queries.GetList;

namespace Application.Features.OnBasvurus.Queries.GetListWithStrings;
public class GetListOnBasvuruWithStringsQuery : IRequest<GetListResponse<GetListOnBasvuruWithStringsListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListOnBasvurus({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetOnBasvurus";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListOnBasvuruWithStringsQueryHandler : IRequestHandler<GetListOnBasvuruWithStringsQuery, GetListResponse<GetListOnBasvuruWithStringsListItemDto>>
    {
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly IMapper _mapper;

        public GetListOnBasvuruWithStringsQueryHandler(IOnBasvuruRepository onBasvuruRepository, IMapper mapper)
        {
            _onBasvuruRepository = onBasvuruRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListOnBasvuruWithStringsListItemDto>> Handle(GetListOnBasvuruWithStringsQuery request, CancellationToken cancellationToken)
        {
            IPaginate<GetListOnBasvuruWithStringsListItemDto> onBasvurus = await _onBasvuruRepository.GetListOnBasvuruWithStringsPaginateAsync(
               index: request.PageRequest.PageIndex,
               size: request.PageRequest.PageSize,
               cancellationToken: cancellationToken
           );

            GetListResponse<GetListOnBasvuruWithStringsListItemDto> response = _mapper.Map<GetListResponse<GetListOnBasvuruWithStringsListItemDto>>(onBasvurus);
            return response;
        }
    }
}