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

namespace Application.Features.Homework.Commands.Create;

public class CreateHomeworkCommand : IRequest<CreatedHomeworkResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int SessionId { get; set; }
    public string Title { get; set; }
    public string UploadFile { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }

    public string[] Roles => [Admin, Write, HomeworkOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomework"];

    public class CreateHomeworkCommandHandler : IRequestHandler<CreateHomeworkCommand, CreatedHomeworkResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly HomeworkBusinessRules _homeworkBusinessRules;

        public CreateHomeworkCommandHandler(IMapper mapper, IHomeworkRepository homeworkRepository,
                                         HomeworkBusinessRules homeworkBusinessRules)
        {
            _mapper = mapper;
            _homeworkRepository = homeworkRepository;
            _homeworkBusinessRules = homeworkBusinessRules;
        }

        public async Task<CreatedHomeworkResponse> Handle(CreateHomeworkCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Homework homework = _mapper.Map<Domain.Entities.Homework>(request);

            await _homeworkRepository.AddAsync(homework);

            CreatedHomeworkResponse response = _mapper.Map<CreatedHomeworkResponse>(homework);
            return response;
        }
    }
}