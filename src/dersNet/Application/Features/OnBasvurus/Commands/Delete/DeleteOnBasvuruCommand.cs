using Application.Features.OnBasvurus.Constants;
using Application.Features.OnBasvurus.Constants;
using Application.Features.OnBasvurus.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.OnBasvurus.Constants.OnBasvurusOperationClaims;

namespace Application.Features.OnBasvurus.Commands.Delete;

public class DeleteOnBasvuruCommand : IRequest<DeletedOnBasvuruResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, OnBasvurusOperationClaims.Delete];

    public bool BypassCache { get; } = true;
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetOnBasvurus"];

    public class DeleteOnBasvuruCommandHandler : IRequestHandler<DeleteOnBasvuruCommand, DeletedOnBasvuruResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly OnBasvuruBusinessRules _onBasvuruBusinessRules;

        public DeleteOnBasvuruCommandHandler(IMapper mapper, IOnBasvuruRepository onBasvuruRepository,
                                         OnBasvuruBusinessRules onBasvuruBusinessRules)
        {
            _mapper = mapper;
            _onBasvuruRepository = onBasvuruRepository;
            _onBasvuruBusinessRules = onBasvuruBusinessRules;
        }

        public async Task<DeletedOnBasvuruResponse> Handle(DeleteOnBasvuruCommand request, CancellationToken cancellationToken)
        {
            OnBasvuru? onBasvuru = await _onBasvuruRepository.GetAsync(predicate: ob => ob.Id == request.Id, cancellationToken: cancellationToken);
            await _onBasvuruBusinessRules.OnBasvuruShouldExistWhenSelected(onBasvuru);

            await _onBasvuruRepository.DeleteAsync(onBasvuru!);

            DeletedOnBasvuruResponse response = _mapper.Map<DeletedOnBasvuruResponse>(onBasvuru);
            return response;
        }
    }
}