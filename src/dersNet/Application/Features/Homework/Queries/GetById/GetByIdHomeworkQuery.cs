using Application.Features.Homework.Constants;
using Application.Features.Homework.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Homework.Constants.HomeworkOperationClaims;

namespace Application.Features.Homework.Queries.GetById;

public class GetByIdHomeworkQuery : IRequest<GetByIdHomeworkResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdHomeworkQueryHandler : IRequestHandler<GetByIdHomeworkQuery, GetByIdHomeworkResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly HomeworkBusinessRules _homeworkBusinessRules;

        public GetByIdHomeworkQueryHandler(IMapper mapper, IHomeworkRepository homeworkRepository, HomeworkBusinessRules homeworkBusinessRules)
        {
            _mapper = mapper;
            _homeworkRepository = homeworkRepository;
            _homeworkBusinessRules = homeworkBusinessRules;
        }

        public async Task<GetByIdHomeworkResponse> Handle(GetByIdHomeworkQuery request, CancellationToken cancellationToken)
        {
            Homework? homework = await _homeworkRepository.GetAsync(predicate: h => h.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkBusinessRules.HomeworkShouldExistWhenSelected(homework);

            GetByIdHomeworkResponse response = _mapper.Map<GetByIdHomeworkResponse>(homework);
            return response;
        }
    }
}