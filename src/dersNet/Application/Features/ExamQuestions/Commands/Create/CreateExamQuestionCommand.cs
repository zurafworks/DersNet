using Application.Features.ExamQuestions.Constants;
using Application.Features.ExamQuestions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.ExamQuestions.Constants.ExamQuestionsOperationClaims;

namespace Application.Features.ExamQuestions.Commands.Create;

public class CreateExamQuestionCommand : IRequest<CreatedExamQuestionResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }

    public string[] Roles => [Admin, Write, ExamQuestionsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetExamQuestions"];

    public class CreateExamQuestionCommandHandler : IRequestHandler<CreateExamQuestionCommand, CreatedExamQuestionResponse>
    {
        private readonly IMapper _mapper;
        private readonly IExamQuestionRepository _examQuestionRepository;
        private readonly ExamQuestionBusinessRules _examQuestionBusinessRules;

        public CreateExamQuestionCommandHandler(IMapper mapper, IExamQuestionRepository examQuestionRepository,
                                         ExamQuestionBusinessRules examQuestionBusinessRules)
        {
            _mapper = mapper;
            _examQuestionRepository = examQuestionRepository;
            _examQuestionBusinessRules = examQuestionBusinessRules;
        }

        public async Task<CreatedExamQuestionResponse> Handle(CreateExamQuestionCommand request, CancellationToken cancellationToken)
        {
            ExamQuestion examQuestion = _mapper.Map<ExamQuestion>(request);

            await _examQuestionRepository.AddAsync(examQuestion);

            CreatedExamQuestionResponse response = _mapper.Map<CreatedExamQuestionResponse>(examQuestion);
            return response;
        }
    }
}