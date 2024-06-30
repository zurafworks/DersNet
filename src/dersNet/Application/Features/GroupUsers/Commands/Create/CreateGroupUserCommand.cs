using Application.Features.GroupUsers.Constants;
using Application.Features.GroupUsers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using Domain.Enums;
using static Application.Features.GroupUsers.Constants.GroupUsersOperationClaims;

namespace Application.Features.GroupUsers.Commands.Create;

public class CreateGroupUserCommand : IRequest<CreatedGroupUserResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid GroupId { get; set; }
    public Guid UserId { get; set; }
    public UserStatus Status { get; set; }

    public string[] Roles => [Admin, Write, GroupUsersOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGroupUsers"];

    public class CreateGroupUserCommandHandler : IRequestHandler<CreateGroupUserCommand, CreatedGroupUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupUserRepository _groupUserRepository;
        private readonly GroupUserBusinessRules _groupUserBusinessRules;

        public CreateGroupUserCommandHandler(IMapper mapper, IGroupUserRepository groupUserRepository,
                                         GroupUserBusinessRules groupUserBusinessRules)
        {
            _mapper = mapper;
            _groupUserRepository = groupUserRepository;
            _groupUserBusinessRules = groupUserBusinessRules;
        }

        public async Task<CreatedGroupUserResponse> Handle(CreateGroupUserCommand request, CancellationToken cancellationToken)
        {
            GroupUser groupUser = _mapper.Map<GroupUser>(request);

            await _groupUserRepository.AddAsync(groupUser);

            CreatedGroupUserResponse response = _mapper.Map<CreatedGroupUserResponse>(groupUser);
            return response;
        }
    }
}