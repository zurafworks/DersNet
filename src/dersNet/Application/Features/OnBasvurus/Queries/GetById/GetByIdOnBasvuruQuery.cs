using Application.Features.OnBasvurus.Constants;
using Application.Features.OnBasvurus.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.OnBasvurus.Constants.OnBasvurusOperationClaims;

namespace Application.Features.OnBasvurus.Queries.GetById;

public class GetByIdOnBasvuruQuery : IRequest<GetByIdOnBasvuruResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdOnBasvuruQueryHandler : IRequestHandler<GetByIdOnBasvuruQuery, GetByIdOnBasvuruResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOnBasvuruRepository _onBasvuruRepository;
        private readonly OnBasvuruBusinessRules _onBasvuruBusinessRules;

        public GetByIdOnBasvuruQueryHandler(IMapper mapper, IOnBasvuruRepository onBasvuruRepository, OnBasvuruBusinessRules onBasvuruBusinessRules)
        {
            _mapper = mapper;
            _onBasvuruRepository = onBasvuruRepository;
            _onBasvuruBusinessRules = onBasvuruBusinessRules;
        }

        public async Task<GetByIdOnBasvuruResponse> Handle(GetByIdOnBasvuruQuery request, CancellationToken cancellationToken)
        {
            //OnBasvuru? onBasvuru = await _onBasvuruRepository.GetAsync(predicate: ob => ob.Id == request.Id, cancellationToken: cancellationToken);

            GetByIdOnBasvuruResponse response = await _onBasvuruRepository.GetByIdOnBasvuruAsync(request.Id);
            await _onBasvuruBusinessRules.GetByIdBasvuruResponseMustNotNull(response);

            return response;
        }
    }
}