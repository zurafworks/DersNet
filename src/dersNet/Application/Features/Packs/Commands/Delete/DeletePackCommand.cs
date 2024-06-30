using Application.Features.Packs.Constants;
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
using static Application.Features.Packs.Constants.PacksOperationClaims;

namespace Application.Features.Packs.Commands.Delete;

public class DeletePackCommand : IRequest<DeletedPackResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, PacksOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPacks"];

    public class DeletePackCommandHandler : IRequestHandler<DeletePackCommand, DeletedPackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPackRepository _packRepository;
        private readonly PackBusinessRules _packBusinessRules;

        public DeletePackCommandHandler(IMapper mapper, IPackRepository packRepository,
                                         PackBusinessRules packBusinessRules)
        {
            _mapper = mapper;
            _packRepository = packRepository;
            _packBusinessRules = packBusinessRules;
        }

        public async Task<DeletedPackResponse> Handle(DeletePackCommand request, CancellationToken cancellationToken)
        {
            Pack? pack = await _packRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _packBusinessRules.PackShouldExistWhenSelected(pack);

            await _packRepository.DeleteAsync(pack!);

            DeletedPackResponse response = _mapper.Map<DeletedPackResponse>(pack);
            return response;
        }
    }
}