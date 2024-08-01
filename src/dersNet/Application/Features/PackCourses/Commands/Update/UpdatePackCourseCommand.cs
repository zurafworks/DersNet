using Application.Features.PackCourses.Constants;
using Application.Features.PackCourses.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.PackCourses.Constants.PackCoursesOperationClaims;

namespace Application.Features.PackCourses.Commands.Update;

public class UpdatePackCourseCommand : IRequest<UpdatedPackCourseResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }

    public string[] Roles => [Admin, Write, PackCoursesOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPackCourses"];

    public class UpdatePackCourseCommandHandler : IRequestHandler<UpdatePackCourseCommand, UpdatedPackCourseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackCourseRepository _packCourseRepository;
        private readonly PackCourseBusinessRules _packCourseBusinessRules;

        public UpdatePackCourseCommandHandler(IMapper mapper, IPackCourseRepository packCourseRepository,
                                         PackCourseBusinessRules packCourseBusinessRules)
        {
            _mapper = mapper;
            _packCourseRepository = packCourseRepository;
            _packCourseBusinessRules = packCourseBusinessRules;
        }

        public async Task<UpdatedPackCourseResponse> Handle(UpdatePackCourseCommand request, CancellationToken cancellationToken)
        {
            PackCourse? packCourse = await _packCourseRepository.GetAsync(predicate: pc => pc.Id == request.Id, cancellationToken: cancellationToken);
            await _packCourseBusinessRules.PackCourseShouldExistWhenSelected(packCourse);
            packCourse = _mapper.Map(request, packCourse);

            await _packCourseRepository.UpdateAsync(packCourse!);

            UpdatedPackCourseResponse response = _mapper.Map<UpdatedPackCourseResponse>(packCourse);
            return response;
        }
    }
}