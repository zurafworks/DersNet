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

namespace Application.Features.Questions.Commands.Update;

public class UpdateQuestionWithChoicesCommand : IRequest<UpdatedQuestionWithChoicesResponse>, /*ISecuredRequest,*/ ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    //public Guid Id { get; set; }
    //public Guid LessonId { get; set; }
    //public string Text { get; set; }
    //public string Image { get; set; }

    public Question Question { get; set; }

    public List<Choice> Choices { get; set; }

    public string[] Roles => [Admin, Write, QuestionsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetQuestions"];

    public class UpdateQuestionCommandHandler : IRequestHandler<UpdateQuestionWithChoicesCommand, UpdatedQuestionWithChoicesResponse>
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;
        private readonly QuestionBusinessRules _questionBusinessRules;

        public UpdateQuestionCommandHandler(
            IMapper mapper,
            IQuestionRepository questionRepository,
            IChoiceRepository choiceRepository,
            QuestionBusinessRules questionBusinessRules
            )
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
            _choiceRepository = choiceRepository;
            _questionBusinessRules = questionBusinessRules;
        }

        public async Task<UpdatedQuestionWithChoicesResponse> Handle(UpdateQuestionWithChoicesCommand request, CancellationToken cancellationToken)
        {
            Question? question = await _questionRepository.GetAsync(predicate: q => q.Id == request.Question.Id, cancellationToken: cancellationToken, enableTracking: true);
            List<Choice>? choices = await _choiceRepository.GetListByQuestionId(questionId: request.Question.Id, cancellationToken: cancellationToken);

            choices.ForEach(choice =>
            {
                var matchingChoice = request.Choices.FirstOrDefault(c => c.Id == choice.Id);
                if (matchingChoice != null)
                {
                    choice.UpdatedDate = DateTime.Now;
                }
                else
                {
                    choice.DeletedDate = DateTime.Now;
                }
            });

            request.Choices.ForEach(choice =>
            {
                var matchingChoice = choices.FirstOrDefault(c => c.Id == choice.Id);
                if (matchingChoice == null)
                {
                    choice.CreatedDate = DateTime.Now;
                    choices.Add(choice);
                }
            });


            await _questionBusinessRules.QuestionShouldExistWhenSelected(question);
            question = _mapper.Map(request.Question, question);


            //await _questionRepository.UpdateAsync(question!);
            await _questionRepository.UpdateQuestionWithChoices(question: request.Question, choices: choices, cancellationToken: cancellationToken);

            UpdatedQuestionWithChoicesResponse response = _mapper.Map<UpdatedQuestionWithChoicesResponse>(question);

            response.Question = question;
            response.Choices = choices;
            return response;
        }
    }
}
