using Application.Features.Packs.Constants;
using Application.Features.Packs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Packs.Constants.PacksOperationClaims;

namespace Application.Features.Packs.Queries.GetById;

public class GetByIdPackQuery : IRequest<GetByIdPackResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdPackQueryHandler : IRequestHandler<GetByIdPackQuery, GetByIdPackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackRepository _packRepository;
        private readonly PackBusinessRules _packBusinessRules;

        public GetByIdPackQueryHandler(IMapper mapper, IPackRepository packRepository, PackBusinessRules packBusinessRules)
        {
            _mapper = mapper;
            _packRepository = packRepository;
            _packBusinessRules = packBusinessRules;
        }

        public async Task<GetByIdPackResponse> Handle(GetByIdPackQuery request, CancellationToken cancellationToken)
        {
            Pack? pack = await _packRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _packBusinessRules.PackShouldExistWhenSelected(pack);

            GetByIdPackResponse response = _mapper.Map<GetByIdPackResponse>(pack);
            return response;
        }
    }
}