using Application.Features.PackCourses.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.PackCourses.Constants.PackCoursesOperationClaims;

namespace Application.Features.PackCourses.Queries.GetList;

public class GetListPackCourseQuery : IRequest<GetListResponse<GetListPackCourseListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListPackCourses({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetPackCourses";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListPackCourseQueryHandler : IRequestHandler<GetListPackCourseQuery, GetListResponse<GetListPackCourseListItemDto>>
    {
        private readonly IPackCourseRepository _packCourseRepository;
        private readonly IMapper _mapper;

        public GetListPackCourseQueryHandler(IPackCourseRepository packCourseRepository, IMapper mapper)
        {
            _packCourseRepository = packCourseRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListPackCourseListItemDto>> Handle(GetListPackCourseQuery request, CancellationToken cancellationToken)
        {
            IPaginate<PackCourse> packCourses = await _packCourseRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListPackCourseListItemDto> response = _mapper.Map<GetListResponse<GetListPackCourseListItemDto>>(packCourses);
            return response;
        }
    }
}