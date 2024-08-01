using Application.Features.PackCourses.Constants;
using Application.Features.PackCourses.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.PackCourses.Constants.PackCoursesOperationClaims;

namespace Application.Features.PackCourses.Queries.GetById;

public class GetByIdPackCourseQuery : IRequest<GetByIdPackCourseResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdPackCourseQueryHandler : IRequestHandler<GetByIdPackCourseQuery, GetByIdPackCourseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackCourseRepository _packCourseRepository;
        private readonly PackCourseBusinessRules _packCourseBusinessRules;

        public GetByIdPackCourseQueryHandler(IMapper mapper, IPackCourseRepository packCourseRepository, PackCourseBusinessRules packCourseBusinessRules)
        {
            _mapper = mapper;
            _packCourseRepository = packCourseRepository;
            _packCourseBusinessRules = packCourseBusinessRules;
        }

        public async Task<GetByIdPackCourseResponse> Handle(GetByIdPackCourseQuery request, CancellationToken cancellationToken)
        {
            PackCourse? packCourse = await _packCourseRepository.GetAsync(predicate: pc => pc.Id == request.Id, cancellationToken: cancellationToken);
            await _packCourseBusinessRules.PackCourseShouldExistWhenSelected(packCourse);

            GetByIdPackCourseResponse response = _mapper.Map<GetByIdPackCourseResponse>(packCourse);
            return response;
        }
    }
}