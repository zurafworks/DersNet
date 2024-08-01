using Application.Features.OnBasvurus.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Application.Features.OnBasvurus.Queries.GetById;

namespace Application.Features.OnBasvurus.Rules;

public class OnBasvuruBusinessRules : BaseBusinessRules
{
    private readonly IOnBasvuruRepository _onBasvuruRepository;
    private readonly ILocalizationService _localizationService;

    public OnBasvuruBusinessRules(IOnBasvuruRepository onBasvuruRepository, ILocalizationService localizationService)
    {
        _onBasvuruRepository = onBasvuruRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, OnBasvurusBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task OnBasvuruShouldExistWhenSelected(OnBasvuru? onBasvuru)
    {
        if (onBasvuru == null)
            await throwBusinessException(OnBasvurusBusinessMessages.OnBasvuruNotExists);
    }

    public async Task OnBasvuruIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        OnBasvuru? onBasvuru = await _onBasvuruRepository.GetAsync(
            predicate: ob => ob.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await OnBasvuruShouldExistWhenSelected(onBasvuru);
    }
    public async Task GetByIdBasvuruResponseMustNotNull(GetByIdOnBasvuruResponse onBasvuru)
    {
        if (onBasvuru==null)
        {
            await throwBusinessException(OnBasvurusBusinessMessages.OnBasvuruDtoMustNotNull);
        }
    }
}