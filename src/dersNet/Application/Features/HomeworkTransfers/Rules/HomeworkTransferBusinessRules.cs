using Application.Features.HomeworkTransfers.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.HomeworkTransfers.Rules;

public class HomeworkTransferBusinessRules : BaseBusinessRules
{
    private readonly IHomeworkTransferRepository _homeworkTransferRepository;
    private readonly ILocalizationService _localizationService;

    public HomeworkTransferBusinessRules(IHomeworkTransferRepository homeworkTransferRepository, ILocalizationService localizationService)
    {
        _homeworkTransferRepository = homeworkTransferRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, HomeworkTransfersBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task HomeworkTransferShouldExistWhenSelected(HomeworkTransfer? homeworkTransfer)
    {
        if (homeworkTransfer == null)
            await throwBusinessException(HomeworkTransfersBusinessMessages.HomeworkTransferNotExists);
    }

    public async Task HomeworkTransferIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        HomeworkTransfer? homeworkTransfer = await _homeworkTransferRepository.GetAsync(
            predicate: ht => ht.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await HomeworkTransferShouldExistWhenSelected(homeworkTransfer);
    }
}