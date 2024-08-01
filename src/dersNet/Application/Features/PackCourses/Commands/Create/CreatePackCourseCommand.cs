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

namespace Application.Features.PackCourses.Commands.Create;

public class CreatePackCourseCommand : IRequest<CreatedPackCourseResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }

    public string[] Roles => [Admin, Write, PackCoursesOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPackCourses"];

    public class CreatePackCourseCommandHandler : IRequestHandler<CreatePackCourseCommand, CreatedPackCourseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackCourseRepository _packCourseRepository;
        private readonly PackCourseBusinessRules _packCourseBusinessRules;

        public CreatePackCourseCommandHandler(IMapper mapper, IPackCourseRepository packCourseRepository,
                                         PackCourseBusinessRules packCourseBusinessRules)
        {
            _mapper = mapper;
            _packCourseRepository = packCourseRepository;
            _packCourseBusinessRules = packCourseBusinessRules;
        }

        public async Task<CreatedPackCourseResponse> Handle(CreatePackCourseCommand request, CancellationToken cancellationToken)
        {
            PackCourse packCourse = _mapper.Map<PackCourse>(request);

            await _packCourseRepository.AddAsync(packCourse);

            CreatedPackCourseResponse response = _mapper.Map<CreatedPackCourseResponse>(packCourse);
            return response;
        }
    }
}