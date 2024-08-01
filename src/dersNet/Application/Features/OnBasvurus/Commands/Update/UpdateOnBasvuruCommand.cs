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

namespace Application.Features.OnBasvurus.Commands.Update;

public class UpdateOnBasvuruCommand : IRequest<UpdatedOnBasvuruResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid LessonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string VeliFirstName { get; set; }
    public string VeliLastName { get; set; }
    public double NotOrtalamasi { get; set; }
    public string OkulAdi { get; set; }
    public string VeliCepNo { get; set; }
    public string OgrCepNo { get; set; }

    public string[] Roles => [Admin, Write, OnBasvurusOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetOnBasvurus"];

    public class UpdateOnBasvuruCommandHandler : IRequestHandler<UpdateOnBasvuruCommand, UpdatedOnBasvuruResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly OnBasvuruBusinessRules _onBasvuruBusinessRules;

        public UpdateOnBasvuruCommandHandler(IMapper mapper, IOnBasvuruRepository onBasvuruRepository,
                                         OnBasvuruBusinessRules onBasvuruBusinessRules)
        {
            _mapper = mapper;
            _onBasvuruRepository = onBasvuruRepository;
            _onBasvuruBusinessRules = onBasvuruBusinessRules;
        }

        public async Task<UpdatedOnBasvuruResponse> Handle(UpdateOnBasvuruCommand request, CancellationToken cancellationToken)
        {
            OnBasvuru? onBasvuru = await _onBasvuruRepository.GetAsync(predicate: ob => ob.Id == request.Id, cancellationToken: cancellationToken);
            await _onBasvuruBusinessRules.OnBasvuruShouldExistWhenSelected(onBasvuru);
            onBasvuru = _mapper.Map(request, onBasvuru);

            await _onBasvuruRepository.UpdateAsync(onBasvuru!);

            UpdatedOnBasvuruResponse response = _mapper.Map<UpdatedOnBasvuruResponse>(onBasvuru);
            return response;
        }
    }
}