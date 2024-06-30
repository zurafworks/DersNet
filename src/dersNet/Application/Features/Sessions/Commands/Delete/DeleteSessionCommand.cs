using Application.Features.Sessions.Constants;
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

namespace Application.Features.Sessions.Commands.Delete;

public class DeleteSessionCommand : IRequest<DeletedSessionResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, SessionsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSessions"];

    public class DeleteSessionCommandHandler : IRequestHandler<DeleteSessionCommand, DeletedSessionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISessionRepository _sessionRepository;
        private readonly SessionBusinessRules _sessionBusinessRules;

        public DeleteSessionCommandHandler(IMapper mapper, ISessionRepository sessionRepository,
                                         SessionBusinessRules sessionBusinessRules)
        {
            _mapper = mapper;
            _sessionRepository = sessionRepository;
            _sessionBusinessRules = sessionBusinessRules;
        }

        public async Task<DeletedSessionResponse> Handle(DeleteSessionCommand request, CancellationToken cancellationToken)
        {
            Session? session = await _sessionRepository.GetAsync(predicate: s => s.Id == request.Id, cancellationToken: cancellationToken);
            await _sessionBusinessRules.SessionShouldExistWhenSelected(session);

            await _sessionRepository.DeleteAsync(session!);

            DeletedSessionResponse response = _mapper.Map<DeletedSessionResponse>(session);
            return response;
        }
    }
}