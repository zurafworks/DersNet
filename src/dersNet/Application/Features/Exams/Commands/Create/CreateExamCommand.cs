using Application.Features.Exams.Constants;
using Application.Features.Exams.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Exams.Constants.ExamsOperationClaims;

namespace Application.Features.Exams.Commands.Create;

public class CreateExamCommand : IRequest<CreatedExamResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid LessonId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }

    public string[] Roles => [Admin, Write, ExamsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetExams"];

    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, CreatedExamResponse>
    {
        private readonly IMapper _mapper;
        private readonly IExamRepository _examRepository;
        private readonly ExamBusinessRules _examBusinessRules;

        public CreateExamCommandHandler(IMapper mapper, IExamRepository examRepository,
                                         ExamBusinessRules examBusinessRules)
        {
            _mapper = mapper;
            _examRepository = examRepository;
            _examBusinessRules = examBusinessRules;
        }

        public async Task<CreatedExamResponse> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            Exam exam = _mapper.Map<Exam>(request);

            await _examRepository.AddAsync(exam);

            CreatedExamResponse response = _mapper.Map<CreatedExamResponse>(exam);
            return response;
        }
    }
}