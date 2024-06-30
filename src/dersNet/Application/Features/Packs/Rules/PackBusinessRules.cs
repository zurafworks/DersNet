using Application.Features.Packs.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Packs.Rules;

public class PackBusinessRules : BaseBusinessRules
{
    private readonly IPackRepository _packRepository;
    private readonly ILocalizationService _localizationService;

    public PackBusinessRules(IPackRepository packRepository, ILocalizationService localizationService)
    {
        _packRepository = packRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, PacksBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task PackShouldExistWhenSelected(Pack? pack)
    {
        if (pack == null)
            await throwBusinessException(PacksBusinessMessages.PackNotExists);
    }

    public async Task PackIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Pack? pack = await _packRepository.GetAsync(
            predicate: p => p.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await PackShouldExistWhenSelected(pack);
    }
}