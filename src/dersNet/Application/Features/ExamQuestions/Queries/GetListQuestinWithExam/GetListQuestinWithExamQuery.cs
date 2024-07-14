using Application.Features.ExamQuestions.Constants;
using Application.Features.ExamQuestions.Rules;
using AutoMapper;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;
using static Application.Features.ExamQuestions.Constants.ExamQuestionsOperationClaims;

namespace Application.Features.ExamQuestions.Queries.GetListQuestinWithExam;

public class GetListQuestinWithExamQuery : IRequest<GetListQuestinWithExamResponse>, ISecuredRequest, ICachableRequest, ILoggableRequest
{

    public string[] Roles => [Admin, Read, ExamQuestionsOperationClaims.GetListQuestinWithExam];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListQuestinWithExam";
    public string? CacheGroupKey => "GetExamQuestions";
    public TimeSpan? SlidingExpiration { get; }
    
    public class GetListQuestinWithExamQueryHandler : IRequestHandler<GetListQuestinWithExamQuery, GetListQuestinWithExamResponse>
    {
        private readonly IMapper _mapper;
        private readonly ExamQuestionBusinessRules _examQuestionBusinessRules;

        public GetListQuestinWithExamQueryHandler(IMapper mapper, ExamQuestionBusinessRules examQuestionBusinessRules)
        {
            _mapper = mapper;
            _examQuestionBusinessRules = examQuestionBusinessRules;
        }

        public async Task<GetListQuestinWithExamResponse> Handle(GetListQuestinWithExamQuery request, CancellationToken cancellationToken)
        {
            GetListQuestinWithExamResponse response = _mapper.Map<GetListQuestinWithExamResponse>(null);
            return response;
        }
    }
}
