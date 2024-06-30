using Application.Features.Packs.Constants;
using Application.Features.Packs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using Domain.Enums;
using static Application.Features.Packs.Constants.PacksOperationClaims;

namespace Application.Features.Packs.Commands.Create;

public class CreatePackCommand : IRequest<CreatedPackResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public PriceCurrency PriceCurrency { get; set; }
    public int TaxRate { get; set; }

    public string[] Roles => [Admin, Write, PacksOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPacks"];

    public class CreatePackCommandHandler : IRequestHandler<CreatePackCommand, CreatedPackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackRepository _packRepository;
        private readonly PackBusinessRules _packBusinessRules;

        public CreatePackCommandHandler(IMapper mapper, IPackRepository packRepository,
                                         PackBusinessRules packBusinessRules)
        {
            _mapper = mapper;
            _packRepository = packRepository;
            _packBusinessRules = packBusinessRules;
        }

        public async Task<CreatedPackResponse> Handle(CreatePackCommand request, CancellationToken cancellationToken)
        {
            Pack pack = _mapper.Map<Pack>(request);

            await _packRepository.AddAsync(pack);

            CreatedPackResponse response = _mapper.Map<CreatedPackResponse>(pack);
            return response;
        }
    }
}