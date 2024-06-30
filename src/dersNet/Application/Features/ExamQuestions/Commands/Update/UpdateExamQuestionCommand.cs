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

namespace Application.Features.ExamQuestions.Commands.Update;

public class UpdateExamQuestionCommand : IRequest<UpdatedExamQuestionResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }

    public string[] Roles => [Admin, Write, ExamQuestionsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetExamQuestions"];

    public class UpdateExamQuestionCommandHandler : IRequestHandler<UpdateExamQuestionCommand, UpdatedExamQuestionResponse>
    {
        private readonly IMapper _mapper;
        private readonly IExamQuestionRepository _examQuestionRepository;
        private readonly ExamQuestionBusinessRules _examQuestionBusinessRules;

        public UpdateExamQuestionCommandHandler(IMapper mapper, IExamQuestionRepository examQuestionRepository,
                                         ExamQuestionBusinessRules examQuestionBusinessRules)
        {
            _mapper = mapper;
            _examQuestionRepository = examQuestionRepository;
            _examQuestionBusinessRules = examQuestionBusinessRules;
        }

        public async Task<UpdatedExamQuestionResponse> Handle(UpdateExamQuestionCommand request, CancellationToken cancellationToken)
        {
            ExamQuestion? examQuestion = await _examQuestionRepository.GetAsync(predicate: eq => eq.Id == request.Id, cancellationToken: cancellationToken);
            await _examQuestionBusinessRules.ExamQuestionShouldExistWhenSelected(examQuestion);
            examQuestion = _mapper.Map(request, examQuestion);

            await _examQuestionRepository.UpdateAsync(examQuestion!);

            UpdatedExamQuestionResponse response = _mapper.Map<UpdatedExamQuestionResponse>(examQuestion);
            return response;
        }
    }
}