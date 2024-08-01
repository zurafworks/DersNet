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

namespace Application.Features.OnBasvurus.Queries.GetList;

public class GetListOnBasvuruQuery : IRequest<GetListResponse<GetListOnBasvuruListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListOnBasvurus({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetOnBasvurus";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListOnBasvuruQueryHandler : IRequestHandler<GetListOnBasvuruQuery, GetListResponse<GetListOnBasvuruListItemDto>>
    {
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly IMapper _mapper;

        public GetListOnBasvuruQueryHandler(IOnBasvuruRepository onBasvuruRepository, IMapper mapper)
        {
            _onBasvuruRepository = onBasvuruRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListOnBasvuruListItemDto>> Handle(GetListOnBasvuruQuery request, CancellationToken cancellationToken)
        {
            IPaginate<OnBasvuru> onBasvurus = await _onBasvuruRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListOnBasvuruListItemDto> response = _mapper.Map<GetListResponse<GetListOnBasvuruListItemDto>>(onBasvurus);
            return response;
        }
    }
}