using Application.Features.Sessions.Constants;
using Application.Features.Sessions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Sessions.Constants.SessionsOperationClaims;

namespace Application.Features.Sessions.Queries.GetById;

public class GetByIdSessionQuery : IRequest<GetByIdSessionResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdSessionQueryHandler : IRequestHandler<GetByIdSessionQuery, GetByIdSessionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISessionRepository _sessionRepository;
        private readonly SessionBusinessRules _sessionBusinessRules;

        public GetByIdSessionQueryHandler(IMapper mapper, ISessionRepository sessionRepository, SessionBusinessRules sessionBusinessRules)
        {
            _mapper = mapper;
            _sessionRepository = sessionRepository;
            _sessionBusinessRules = sessionBusinessRules;
        }

        public async Task<GetByIdSessionResponse> Handle(GetByIdSessionQuery request, CancellationToken cancellationToken)
        {
            Session? session = await _sessionRepository.GetAsync(predicate: s => s.Id == request.Id, cancellationToken: cancellationToken);
            await _sessionBusinessRules.SessionShouldExistWhenSelected(session);

            GetByIdSessionResponse response = _mapper.Map<GetByIdSessionResponse>(session);
            return response;
        }
    }
}