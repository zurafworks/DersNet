using Application.Features.GroupUsers.Constants;
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
using static Application.Features.GroupUsers.Constants.GroupUsersOperationClaims;

namespace Application.Features.GroupUsers.Commands.Delete;

public class DeleteGroupUserCommand : IRequest<DeletedGroupUserResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, GroupUsersOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGroupUsers"];

    public class DeleteGroupUserCommandHandler : IRequestHandler<DeleteGroupUserCommand, DeletedGroupUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupUserRepository _groupUserRepository;
        private readonly GroupUserBusinessRules _groupUserBusinessRules;

        public DeleteGroupUserCommandHandler(IMapper mapper, IGroupUserRepository groupUserRepository,
                                         GroupUserBusinessRules groupUserBusinessRules)
        {
            _mapper = mapper;
            _groupUserRepository = groupUserRepository;
            _groupUserBusinessRules = groupUserBusinessRules;
        }

        public async Task<DeletedGroupUserResponse> Handle(DeleteGroupUserCommand request, CancellationToken cancellationToken)
        {
            GroupUser? groupUser = await _groupUserRepository.GetAsync(predicate: gu => gu.Id == request.Id, cancellationToken: cancellationToken);
            await _groupUserBusinessRules.GroupUserShouldExistWhenSelected(groupUser);

            await _groupUserRepository.DeleteAsync(groupUser!);

            DeletedGroupUserResponse response = _mapper.Map<DeletedGroupUserResponse>(groupUser);
            return response;
        }
    }
}