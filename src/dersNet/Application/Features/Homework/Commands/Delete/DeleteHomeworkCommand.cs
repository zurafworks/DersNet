using Application.Features.Homework.Constants;
using Application.Features.Homework.Constants;
using Application.Features.Homework.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Homework.Constants.HomeworkOperationClaims;

namespace Application.Features.Homework.Commands.Delete;

public class DeleteHomeworkCommand : IRequest<DeletedHomeworkResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, HomeworkOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomework"];

    public class DeleteHomeworkCommandHandler : IRequestHandler<DeleteHomeworkCommand, DeletedHomeworkResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly HomeworkBusinessRules _homeworkBusinessRules;

        public DeleteHomeworkCommandHandler(IMapper mapper, IHomeworkRepository homeworkRepository,
                                         HomeworkBusinessRules homeworkBusinessRules)
        {
            _mapper = mapper;
            _homeworkRepository = homeworkRepository;
            _homeworkBusinessRules = homeworkBusinessRules;
        }

        public async Task<DeletedHomeworkResponse> Handle(DeleteHomeworkCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Homework? homework = await _homeworkRepository.GetAsync(predicate: h => h.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkBusinessRules.HomeworkShouldExistWhenSelected(homework);

            await _homeworkRepository.DeleteAsync(homework!);

            DeletedHomeworkResponse response = _mapper.Map<DeletedHomeworkResponse>(homework);
            return response;
        }
    }
}