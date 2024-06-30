using Application.Features.Lessons.Constants;
using Application.Features.Lessons.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Lessons.Constants.LessonsOperationClaims;

namespace Application.Features.Lessons.Commands.Create;

public class CreateLessonCommand : IRequest<CreatedLessonResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string Title { get; set; }
    public Guid ParentId { get; set; }
    public short Depth { get; set; }
    public int Order { get; set; }

    public string[] Roles => [Admin, Write, LessonsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLessons"];

    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, CreatedLessonResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILessonRepository _lessonRepository;
        private readonly LessonBusinessRules _lessonBusinessRules;

        public CreateLessonCommandHandler(IMapper mapper, ILessonRepository lessonRepository,
                                         LessonBusinessRules lessonBusinessRules)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _lessonBusinessRules = lessonBusinessRules;
        }

        public async Task<CreatedLessonResponse> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            Lesson lesson = _mapper.Map<Lesson>(request);

            await _lessonRepository.AddAsync(lesson);

            CreatedLessonResponse response = _mapper.Map<CreatedLessonResponse>(lesson);
            return response;
        }
    }
}