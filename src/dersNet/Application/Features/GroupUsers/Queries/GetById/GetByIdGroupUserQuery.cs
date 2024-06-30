using Application.Features.GroupUsers.Constants;
using Application.Features.GroupUsers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.GroupUsers.Constants.GroupUsersOperationClaims;

namespace Application.Features.GroupUsers.Queries.GetById;

public class GetByIdGroupUserQuery : IRequest<GetByIdGroupUserResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdGroupUserQueryHandler : IRequestHandler<GetByIdGroupUserQuery, GetByIdGroupUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupUserRepository _groupUserRepository;
        private readonly GroupUserBusinessRules _groupUserBusinessRules;

        public GetByIdGroupUserQueryHandler(IMapper mapper, IGroupUserRepository groupUserRepository, GroupUserBusinessRules groupUserBusinessRules)
        {
            _mapper = mapper;
            _groupUserRepository = groupUserRepository;
            _groupUserBusinessRules = groupUserBusinessRules;
        }

        public async Task<GetByIdGroupUserResponse> Handle(GetByIdGroupUserQuery request, CancellationToken cancellationToken)
        {
            GroupUser? groupUser = await _groupUserRepository.GetAsync(predicate: gu => gu.Id == request.Id, cancellationToken: cancellationToken);
            await _groupUserBusinessRules.GroupUserShouldExistWhenSelected(groupUser);

            GetByIdGroupUserResponse response = _mapper.Map<GetByIdGroupUserResponse>(groupUser);
            return response;
        }
    }
}