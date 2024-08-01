using Application.Features.PackCourses.Constants;
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

namespace Application.Features.PackCourses.Commands.Delete;

public class DeletePackCourseCommand : IRequest<DeletedPackCourseResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, PackCoursesOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPackCourses"];

    public class DeletePackCourseCommandHandler : IRequestHandler<DeletePackCourseCommand, DeletedPackCourseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackCourseRepository _packCourseRepository;
        private readonly PackCourseBusinessRules _packCourseBusinessRules;

        public DeletePackCourseCommandHandler(IMapper mapper, IPackCourseRepository packCourseRepository,
                                         PackCourseBusinessRules packCourseBusinessRules)
        {
            _mapper = mapper;
            _packCourseRepository = packCourseRepository;
            _packCourseBusinessRules = packCourseBusinessRules;
        }

        public async Task<DeletedPackCourseResponse> Handle(DeletePackCourseCommand request, CancellationToken cancellationToken)
        {
            PackCourse? packCourse = await _packCourseRepository.GetAsync(predicate: pc => pc.Id == request.Id, cancellationToken: cancellationToken);
            await _packCourseBusinessRules.PackCourseShouldExistWhenSelected(packCourse);

            await _packCourseRepository.DeleteAsync(packCourse!);

            DeletedPackCourseResponse response = _mapper.Map<DeletedPackCourseResponse>(packCourse);
            return response;
        }
    }
}