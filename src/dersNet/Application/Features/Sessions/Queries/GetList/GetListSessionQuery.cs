using Application.Features.Sessions.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Sessions.Constants.SessionsOperationClaims;

namespace Application.Features.Sessions.Queries.GetList;

public class GetListSessionQuery : IRequest<GetListResponse<GetListSessionListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListSessions({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetSessions";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListSessionQueryHandler : IRequestHandler<GetListSessionQuery, GetListResponse<GetListSessionListItemDto>>
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly IMapper _mapper;

        public GetListSessionQueryHandler(ISessionRepository sessionRepository, IMapper mapper)
        {
            _sessionRepository = sessionRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListSessionListItemDto>> Handle(GetListSessionQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Session> sessions = await _sessionRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListSessionListItemDto> response = _mapper.Map<GetListResponse<GetListSessionListItemDto>>(sessions);
            return response;
        }
    }
}