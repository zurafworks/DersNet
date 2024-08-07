using Application.Features.Lessons.Constants;
using Application.Features.Lessons.Rules;
using AutoMapper;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;
using static Application.Features.Lessons.Constants.LessonsOperationClaims;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Application.Requests;
using Application.Services.Repositories;

namespace Application.Features.Lessons.Queries.GetListWithParent;

public class GetListWithParentQuery : IRequest<GetListResponse<GetListWithParentItemDto>>/*, ISecuredRequest*/,ICachableRequest, ILoggableRequest
{

    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read, LessonsOperationClaims.GetListWithParent];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListWithParent({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetLessons";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListWithParentQueryHandler : IRequestHandler<GetListWithParentQuery, GetListResponse<GetListWithParentItemDto>>
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;
        private readonly LessonBusinessRules _lessonBusinessRules;

        public GetListWithParentQueryHandler(IMapper mapper, LessonBusinessRules lessonBusinessRules, ILessonRepository lessonRepository)
        {
            _mapper = mapper;
            _lessonBusinessRules = lessonBusinessRules;
            _lessonRepository = lessonRepository;
        }

        public async Task<GetListResponse<GetListWithParentItemDto>> Handle(GetListWithParentQuery request, CancellationToken cancellationToken)
        {
            var getListWithParentListPaginate = await _lessonRepository.GetListWithParentPaginateAsync
                (request.PageRequest.PageIndex,
                request.PageRequest.PageSize, cancellationToken);
            GetListResponse<GetListWithParentItemDto> response = _mapper.Map<GetListResponse<GetListWithParentItemDto>>(getListWithParentListPaginate);
            return response;
        }
    }
}
