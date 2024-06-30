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

namespace Application.Features.Packs.Commands.Update;

public class UpdatePackCommand : IRequest<UpdatedPackResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public PriceCurrency PriceCurrency { get; set; }
    public int TaxRate { get; set; }

    public string[] Roles => [Admin, Write, PacksOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPacks"];

    public class UpdatePackCommandHandler : IRequestHandler<UpdatePackCommand, UpdatedPackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackRepository _packRepository;
        private readonly PackBusinessRules _packBusinessRules;

        public UpdatePackCommandHandler(IMapper mapper, IPackRepository packRepository,
                                         PackBusinessRules packBusinessRules)
        {
            _mapper = mapper;
            _packRepository = packRepository;
            _packBusinessRules = packBusinessRules;
        }

        public async Task<UpdatedPackResponse> Handle(UpdatePackCommand request, CancellationToken cancellationToken)
        {
            Pack? pack = await _packRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _packBusinessRules.PackShouldExistWhenSelected(pack);
            pack = _mapper.Map(request, pack);

            await _packRepository.UpdateAsync(pack!);

            UpdatedPackResponse response = _mapper.Map<UpdatedPackResponse>(pack);
            return response;
        }
    }
}