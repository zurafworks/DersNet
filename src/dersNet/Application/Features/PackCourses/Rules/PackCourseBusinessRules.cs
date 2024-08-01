using Application.Features.PackCourses.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.PackCourses.Rules;

public class PackCourseBusinessRules : BaseBusinessRules
{
    private readonly IPackCourseRepository _packCourseRepository;
    private readonly ILocalizationService _localizationService;

    public PackCourseBusinessRules(IPackCourseRepository packCourseRepository, ILocalizationService localizationService)
    {
        _packCourseRepository = packCourseRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, PackCoursesBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task PackCourseShouldExistWhenSelected(PackCourse? packCourse)
    {
        if (packCourse == null)
            await throwBusinessException(PackCoursesBusinessMessages.PackCourseNotExists);
    }

    public async Task PackCourseIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        PackCourse? packCourse = await _packCourseRepository.GetAsync(
            predicate: pc => pc.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await PackCourseShouldExistWhenSelected(packCourse);
    }
}