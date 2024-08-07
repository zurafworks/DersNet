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

namespace Application.Features.OnBasvurus.Commands.Create;

public class CreateOnBasvuruCommand : IRequest<CreatedOnBasvuruResponse>,/* ISecuredRequest,*/ ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
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
    public string OgrEmail { get; set; }

    public string[] Roles => [Admin, Write, OnBasvurusOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetOnBasvurus"];

    public class CreateOnBasvuruCommandHandler : IRequestHandler<CreateOnBasvuruCommand, CreatedOnBasvuruResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly OnBasvuruBusinessRules _onBasvuruBusinessRules;

        public CreateOnBasvuruCommandHandler(IMapper mapper, IOnBasvuruRepository onBasvuruRepository,
                                         OnBasvuruBusinessRules onBasvuruBusinessRules)
        {
            _mapper = mapper;
            _onBasvuruRepository = onBasvuruRepository;
            _onBasvuruBusinessRules = onBasvuruBusinessRules;
        }

        public async Task<CreatedOnBasvuruResponse> Handle(CreateOnBasvuruCommand request, CancellationToken cancellationToken)
        {
            OnBasvuru onBasvuru = _mapper.Map<OnBasvuru>(request);

            await _onBasvuruRepository.AddAsync(onBasvuru);

            CreatedOnBasvuruResponse response = _mapper.Map<CreatedOnBasvuruResponse>(onBasvuru);
            return response;
        }
    }
}