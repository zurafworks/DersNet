using Application.Features.Homework.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Homework.Constants.HomeworkOperationClaims;

namespace Application.Features.Homework.Queries.GetList;

public class GetListHomeworkQuery : IRequest<GetListResponse<GetListHomeworkListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListHomework({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetHomework";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListHomeworkQueryHandler : IRequestHandler<GetListHomeworkQuery, GetListResponse<GetListHomeworkListItemDto>>
    {
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly IMapper _mapper;

        public GetListHomeworkQueryHandler(IHomeworkRepository homeworkRepository, IMapper mapper)
        {
            _homeworkRepository = homeworkRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListHomeworkListItemDto>> Handle(GetListHomeworkQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Homework> homework = await _homeworkRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListHomeworkListItemDto> response = _mapper.Map<GetListResponse<GetListHomeworkListItemDto>>(homework);
            return response;
        }
    }
}