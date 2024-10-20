using Application.Features.Choices.Constants;
using Application.Features.Choices.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Choices.Constants.ChoicesOperationClaims;

namespace Application.Features.Choices.Commands.Create;

public class CreateChoiceCommand : IRequest<CreatedChoiceResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid QuestionId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
    public bool IsAnswer { get; set; }

    public string[] Roles => [Admin, Write, ChoicesOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetChoices"];

    public class CreateChoiceCommandHandler : IRequestHandler<CreateChoiceCommand, CreatedChoiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IChoiceRepository _choiceRepository;
        private readonly ChoiceBusinessRules _choiceBusinessRules;

        public CreateChoiceCommandHandler(IMapper mapper, IChoiceRepository choiceRepository,
                                         ChoiceBusinessRules choiceBusinessRules)
        {
            _mapper = mapper;
            _choiceRepository = choiceRepository;
            _choiceBusinessRules = choiceBusinessRules;
        }

        public async Task<CreatedChoiceResponse> Handle(CreateChoiceCommand request, CancellationToken cancellationToken)
        {
            Choice choice = _mapper.Map<Choice>(request);

            await _choiceRepository.AddAsync(choice);

            CreatedChoiceResponse response = _mapper.Map<CreatedChoiceResponse>(choice);
            return response;
        }
    }
}