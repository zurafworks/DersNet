using Application.Features.Questions.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Questions.Constants.QuestionsOperationClaims;

namespace Application.Features.Questions.Queries.GetListWithChoices;
public class GetListQuestionWithChoicesQuery : IRequest<GetListResponse<GetListQuestionWithChoicesListItemDto>>/*, ISecuredRequest*/ /*, ICachableRequest*/
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListQuestionsWithChoices({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetQuestionsWithChoices";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListQuestionQueryHandler : IRequestHandler<GetListQuestionWithChoicesQuery, GetListResponse<GetListQuestionWithChoicesListItemDto>>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public GetListQuestionQueryHandler(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListQuestionWithChoicesListItemDto>> Handle(GetListQuestionWithChoicesQuery request, CancellationToken cancellationToken)
        {
            IPaginate<GetListQuestionWithChoicesListItemDto> questions = await _questionRepository.GetListWithChoicesPaginateAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            );
            GetListResponse<GetListQuestionWithChoicesListItemDto> response = _mapper.Map<GetListResponse<GetListQuestionWithChoicesListItemDto>>(questions);
            return response;
 
        }
    }
}