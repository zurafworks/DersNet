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

namespace Application.Features.GroupUsers.Commands.Update;

public class UpdateGroupUserCommand : IRequest<UpdatedGroupUserResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid UserId { get; set; }
    public UserStatus Status { get; set; }

    public string[] Roles => [Admin, Write, GroupUsersOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGroupUsers"];

    public class UpdateGroupUserCommandHandler : IRequestHandler<UpdateGroupUserCommand, UpdatedGroupUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupUserRepository _groupUserRepository;
        private readonly GroupUserBusinessRules _groupUserBusinessRules;

        public UpdateGroupUserCommandHandler(IMapper mapper, IGroupUserRepository groupUserRepository,
                                         GroupUserBusinessRules groupUserBusinessRules)
        {
            _mapper = mapper;
            _groupUserRepository = groupUserRepository;
            _groupUserBusinessRules = groupUserBusinessRules;
        }

        public async Task<UpdatedGroupUserResponse> Handle(UpdateGroupUserCommand request, CancellationToken cancellationToken)
        {
            GroupUser? groupUser = await _groupUserRepository.GetAsync(predicate: gu => gu.Id == request.Id, cancellationToken: cancellationToken);
            await _groupUserBusinessRules.GroupUserShouldExistWhenSelected(groupUser);
            groupUser = _mapper.Map(request, groupUser);

            await _groupUserRepository.UpdateAsync(groupUser!);

            UpdatedGroupUserResponse response = _mapper.Map<UpdatedGroupUserResponse>(groupUser);
            return response;
        }
    }
}