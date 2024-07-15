using Application.Features.Exams.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Exams.Constants.ExamsOperationClaims;

namespace Application.Features.Exams.Queries.GetList;

public class GetListExamQuery : IRequest<GetListResponse<GetListExamListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListExams({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetExams";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListExamQueryHandler : IRequestHandler<GetListExamQuery, GetListResponse<GetListExamListItemDto>>
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public GetListExamQueryHandler(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListExamListItemDto>> Handle(GetListExamQuery request, CancellationToken cancellationToken)
        {
            IPaginate<GetListExamListItemDto> exams = await _examRepository.GetExamList(request.PageRequest.PageIndex, request.PageRequest.PageSize, cancellationToken);

            GetListResponse<GetListExamListItemDto> response = _mapper.Map<GetListResponse<GetListExamListItemDto>>(exams);
            return response;
        }
    }
}