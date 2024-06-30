using Application.Features.GroupUsers.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.GroupUsers.Constants.GroupUsersOperationClaims;

namespace Application.Features.GroupUsers.Queries.GetList;

public class GetListGroupUserQuery : IRequest<GetListResponse<GetListGroupUserListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListGroupUsers({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetGroupUsers";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListGroupUserQueryHandler : IRequestHandler<GetListGroupUserQuery, GetListResponse<GetListGroupUserListItemDto>>
    {
        private readonly IGroupUserRepository _groupUserRepository;
        private readonly IMapper _mapper;

        public GetListGroupUserQueryHandler(IGroupUserRepository groupUserRepository, IMapper mapper)
        {
            _groupUserRepository = groupUserRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListGroupUserListItemDto>> Handle(GetListGroupUserQuery request, CancellationToken cancellationToken)
        {
            IPaginate<GroupUser> groupUsers = await _groupUserRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListGroupUserListItemDto> response = _mapper.Map<GetListResponse<GetListGroupUserListItemDto>>(groupUsers);
            return response;
        }
    }
}