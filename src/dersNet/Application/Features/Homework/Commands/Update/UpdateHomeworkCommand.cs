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

namespace Application.Features.Homework.Commands.Update;

public class UpdateHomeworkCommand : IRequest<UpdatedHomeworkResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public int SessionId { get; set; }
    public string Title { get; set; }
    public string UploadFile { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }

    public string[] Roles => [Admin, Write, HomeworkOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomework"];

    public class UpdateHomeworkCommandHandler : IRequestHandler<UpdateHomeworkCommand, UpdatedHomeworkResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly HomeworkBusinessRules _homeworkBusinessRules;

        public UpdateHomeworkCommandHandler(IMapper mapper, IHomeworkRepository homeworkRepository,
                                         HomeworkBusinessRules homeworkBusinessRules)
        {
            _mapper = mapper;
            _homeworkRepository = homeworkRepository;
            _homeworkBusinessRules = homeworkBusinessRules;
        }

        public async Task<UpdatedHomeworkResponse> Handle(UpdateHomeworkCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Homework? homework = await _homeworkRepository.GetAsync(predicate: h => h.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkBusinessRules.HomeworkShouldExistWhenSelected(homework);
            homework = _mapper.Map(request, homework);

            await _homeworkRepository.UpdateAsync(homework!);

            UpdatedHomeworkResponse response = _mapper.Map<UpdatedHomeworkResponse>(homework);
            return response;
        }
    }
}