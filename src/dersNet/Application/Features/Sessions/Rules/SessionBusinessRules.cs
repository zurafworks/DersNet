using Application.Features.Sessions.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Sessions.Rules;

public class SessionBusinessRules : BaseBusinessRules
{
    private readonly ISessionRepository _sessionRepository;
    private readonly ILocalizationService _localizationService;

    public SessionBusinessRules(ISessionRepository sessionRepository, ILocalizationService localizationService)
    {
        _sessionRepository = sessionRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, SessionsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task SessionShouldExistWhenSelected(Session? session)
    {
        if (session == null)
            await throwBusinessException(SessionsBusinessMessages.SessionNotExists);
    }

    public async Task SessionIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Session? session = await _sessionRepository.GetAsync(
            predicate: s => s.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await SessionShouldExistWhenSelected(session);
    }
}