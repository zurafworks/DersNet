using Application.Features.Homework.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Homework.Rules;

public class HomeworkBusinessRules : BaseBusinessRules
{
    private readonly IHomeworkRepository _homeworkRepository;
    private readonly ILocalizationService _localizationService;

    public HomeworkBusinessRules(IHomeworkRepository homeworkRepository, ILocalizationService localizationService)
    {
        _homeworkRepository = homeworkRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, HomeworkBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task HomeworkShouldExistWhenSelected(Domain.Entities.Homework? homework)
    {
        if (homework == null)
            await throwBusinessException(HomeworkBusinessMessages.HomeworkNotExists);
    }

    public async Task HomeworkIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Domain.Entities.Homework? homework = await _homeworkRepository.GetAsync(
            predicate: h => h.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await HomeworkShouldExistWhenSelected(homework);
    }
}