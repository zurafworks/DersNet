using Application.Features.Questions.Constants;
using Application.Features.Questions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Questions.Constants.QuestionsOperationClaims;

namespace Application.Features.Questions.Commands.Create;

public class CreateQuestionWithChoicesCommand : IRequest<CreatedQuestionWithChoicesResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    //public Guid LessonId { get; set; }
    //public string Text { get; set; }
    //public string Image { get; set; }

    public Question Question { get; set; }

    public List<Choice> Choices { get; set; }

    public string[] Roles => [Admin, Write, QuestionsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetQuestions"];

    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionWithChoicesCommand, CreatedQuestionWithChoicesResponse>
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;
        private readonly QuestionBusinessRules _questionBusinessRules;

        public CreateQuestionCommandHandler(IMapper mapper, IQuestionRepository questionRepository,
                                         QuestionBusinessRules questionBusinessRules)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
            _questionBusinessRules = questionBusinessRules;
        }

        public async Task<CreatedQuestionWithChoicesResponse> Handle(CreateQuestionWithChoicesCommand request, CancellationToken cancellationToken)
        {
            Question question = _mapper.Map<Question>(request.Question);

            List<Choice> choices = _mapper.Map<List<Choice>>(request.Choices);

            await _questionRepository.AddQuestionWithChoices(question: question, choices: choices, cancellationToken: cancellationToken);

            CreatedQuestionWithChoicesResponse response = _mapper.Map<CreatedQuestionWithChoicesResponse>(question);
            return response;
        }
    }
}