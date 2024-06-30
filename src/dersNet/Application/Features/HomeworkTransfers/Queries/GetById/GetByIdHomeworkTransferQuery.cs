using Application.Features.HomeworkTransfers.Constants;
using Application.Features.HomeworkTransfers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.HomeworkTransfers.Constants.HomeworkTransfersOperationClaims;

namespace Application.Features.HomeworkTransfers.Queries.GetById;

public class GetByIdHomeworkTransferQuery : IRequest<GetByIdHomeworkTransferResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdHomeworkTransferQueryHandler : IRequestHandler<GetByIdHomeworkTransferQuery, GetByIdHomeworkTransferResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkTransferRepository _homeworkTransferRepository;
        private readonly HomeworkTransferBusinessRules _homeworkTransferBusinessRules;

        public GetByIdHomeworkTransferQueryHandler(IMapper mapper, IHomeworkTransferRepository homeworkTransferRepository, HomeworkTransferBusinessRules homeworkTransferBusinessRules)
        {
            _mapper = mapper;
            _homeworkTransferRepository = homeworkTransferRepository;
            _homeworkTransferBusinessRules = homeworkTransferBusinessRules;
        }

        public async Task<GetByIdHomeworkTransferResponse> Handle(GetByIdHomeworkTransferQuery request, CancellationToken cancellationToken)
        {
            HomeworkTransfer? homeworkTransfer = await _homeworkTransferRepository.GetAsync(predicate: ht => ht.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkTransferBusinessRules.HomeworkTransferShouldExistWhenSelected(homeworkTransfer);

            GetByIdHomeworkTransferResponse response = _mapper.Map<GetByIdHomeworkTransferResponse>(homeworkTransfer);
            return response;
        }
    }
}