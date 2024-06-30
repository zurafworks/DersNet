using Application.Features.ExamQuestions.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.ExamQuestions.Rules;

public class ExamQuestionBusinessRules : BaseBusinessRules
{
    private readonly IExamQuestionRepository _examQuestionRepository;
    private readonly ILocalizationService _localizationService;

    public ExamQuestionBusinessRules(IExamQuestionRepository examQuestionRepository, ILocalizationService localizationService)
    {
        _examQuestionRepository = examQuestionRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, ExamQuestionsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task ExamQuestionShouldExistWhenSelected(ExamQuestion? examQuestion)
    {
        if (examQuestion == null)
            await throwBusinessException(ExamQuestionsBusinessMessages.ExamQuestionNotExists);
    }

    public async Task ExamQuestionIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        ExamQuestion? examQuestion = await _examQuestionRepository.GetAsync(
            predicate: eq => eq.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ExamQuestionShouldExistWhenSelected(examQuestion);
    }
}