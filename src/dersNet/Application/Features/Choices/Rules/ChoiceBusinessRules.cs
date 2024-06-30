using Application.Features.Choices.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Choices.Rules;

public class ChoiceBusinessRules : BaseBusinessRules
{
    private readonly IChoiceRepository _choiceRepository;
    private readonly ILocalizationService _localizationService;

    public ChoiceBusinessRules(IChoiceRepository choiceRepository, ILocalizationService localizationService)
    {
        _choiceRepository = choiceRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, ChoicesBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task ChoiceShouldExistWhenSelected(Choice? choice)
    {
        if (choice == null)
            await throwBusinessException(ChoicesBusinessMessages.ChoiceNotExists);
    }

    public async Task ChoiceIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Choice? choice = await _choiceRepository.GetAsync(
            predicate: c => c.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ChoiceShouldExistWhenSelected(choice);
    }
}