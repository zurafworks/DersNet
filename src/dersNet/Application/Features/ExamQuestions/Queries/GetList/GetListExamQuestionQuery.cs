using Application.Features.ExamQuestions.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.ExamQuestions.Constants.ExamQuestionsOperationClaims;

namespace Application.Features.ExamQuestions.Queries.GetList;

public class GetListExamQuestionQuery : IRequest<GetListResponse<GetListExamQuestionListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListExamQuestions({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetExamQuestions";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListExamQuestionQueryHandler : IRequestHandler<GetListExamQuestionQuery, GetListResponse<GetListExamQuestionListItemDto>>
    {
        private readonly IExamQuestionRepository _examQuestionRepository;
        private readonly IMapper _mapper;

        public GetListExamQuestionQueryHandler(IExamQuestionRepository examQuestionRepository, IMapper mapper)
        {
            _examQuestionRepository = examQuestionRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListExamQuestionListItemDto>> Handle(GetListExamQuestionQuery request, CancellationToken cancellationToken)
        {
            IPaginate<ExamQuestion> examQuestions = await _examQuestionRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListExamQuestionListItemDto> response = _mapper.Map<GetListResponse<GetListExamQuestionListItemDto>>(examQuestions);
            return response;
        }
    }
}