using Application.Features.Sessions.Constants;
using Application.Features.Sessions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Sessions.Constants.SessionsOperationClaims;

namespace Application.Features.Sessions.Commands.Create;

public class CreateSessionCommand : IRequest<CreatedSessionResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int CourseId { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public Guid LessonId { get; set; }

    public string[] Roles => [Admin, Write, SessionsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSessions"];

    public class CreateSessionCommandHandler : IRequestHandler<CreateSessionCommand, CreatedSessionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISessionRepository _sessionRepository;
        private readonly SessionBusinessRules _sessionBusinessRules;

        public CreateSessionCommandHandler(IMapper mapper, ISessionRepository sessionRepository,
                                         SessionBusinessRules sessionBusinessRules)
        {
            _mapper = mapper;
            _sessionRepository = sessionRepository;
            _sessionBusinessRules = sessionBusinessRules;
        }

        public async Task<CreatedSessionResponse> Handle(CreateSessionCommand request, CancellationToken cancellationToken)
        {
            Session session = _mapper.Map<Session>(request);

            await _sessionRepository.AddAsync(session);

            CreatedSessionResponse response = _mapper.Map<CreatedSessionResponse>(session);
            return response;
        }
    }
}