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

namespace Application.Features.Sessions.Commands.Update;

public class UpdateSessionCommand : IRequest<UpdatedSessionResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public int CourseId { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public Guid LessonId { get; set; }

    public string[] Roles => [Admin, Write, SessionsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSessions"];

    public class UpdateSessionCommandHandler : IRequestHandler<UpdateSessionCommand, UpdatedSessionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISessionRepository _sessionRepository;
        private readonly SessionBusinessRules _sessionBusinessRules;

        public UpdateSessionCommandHandler(IMapper mapper, ISessionRepository sessionRepository,
                                         SessionBusinessRules sessionBusinessRules)
        {
            _mapper = mapper;
            _sessionRepository = sessionRepository;
            _sessionBusinessRules = sessionBusinessRules;
        }

        public async Task<UpdatedSessionResponse> Handle(UpdateSessionCommand request, CancellationToken cancellationToken)
        {
            Session? session = await _sessionRepository.GetAsync(predicate: s => s.Id == request.Id, cancellationToken: cancellationToken);
            await _sessionBusinessRules.SessionShouldExistWhenSelected(session);
            session = _mapper.Map(request, session);

            await _sessionRepository.UpdateAsync(session!);

            UpdatedSessionResponse response = _mapper.Map<UpdatedSessionResponse>(session);
            return response;
        }
    }
}