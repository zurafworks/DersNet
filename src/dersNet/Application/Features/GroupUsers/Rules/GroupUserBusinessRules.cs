using Application.Features.GroupUsers.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.GroupUsers.Rules;

public class GroupUserBusinessRules : BaseBusinessRules
{
    private readonly IGroupUserRepository _groupUserRepository;
    private readonly ILocalizationService _localizationService;

    public GroupUserBusinessRules(IGroupUserRepository groupUserRepository, ILocalizationService localizationService)
    {
        _groupUserRepository = groupUserRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, GroupUsersBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task GroupUserShouldExistWhenSelected(GroupUser? groupUser)
    {
        if (groupUser == null)
            await throwBusinessException(GroupUsersBusinessMessages.GroupUserNotExists);
    }

    public async Task GroupUserIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        GroupUser? groupUser = await _groupUserRepository.GetAsync(
            predicate: gu => gu.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await GroupUserShouldExistWhenSelected(groupUser);
    }
}