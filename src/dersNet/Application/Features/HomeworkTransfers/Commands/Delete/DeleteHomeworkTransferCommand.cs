using Application.Features.HomeworkTransfers.Constants;
using Application.Features.HomeworkTransfers.Constants;
using Application.Features.HomeworkTransfers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.HomeworkTransfers.Constants.HomeworkTransfersOperationClaims;

namespace Application.Features.HomeworkTransfers.Commands.Delete;

public class DeleteHomeworkTransferCommand : IRequest<DeletedHomeworkTransferResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, HomeworkTransfersOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomeworkTransfers"];

    public class DeleteHomeworkTransferCommandHandler : IRequestHandler<DeleteHomeworkTransferCommand, DeletedHomeworkTransferResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkTransferRepository _homeworkTransferRepository;
        private readonly HomeworkTransferBusinessRules _homeworkTransferBusinessRules;

        public DeleteHomeworkTransferCommandHandler(IMapper mapper, IHomeworkTransferRepository homeworkTransferRepository,
                                         HomeworkTransferBusinessRules homeworkTransferBusinessRules)
        {
            _mapper = mapper;
            _homeworkTransferRepository = homeworkTransferRepository;
            _homeworkTransferBusinessRules = homeworkTransferBusinessRules;
        }

        public async Task<DeletedHomeworkTransferResponse> Handle(DeleteHomeworkTransferCommand request, CancellationToken cancellationToken)
        {
            HomeworkTransfer? homeworkTransfer = await _homeworkTransferRepository.GetAsync(predicate: ht => ht.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkTransferBusinessRules.HomeworkTransferShouldExistWhenSelected(homeworkTransfer);

            await _homeworkTransferRepository.DeleteAsync(homeworkTransfer!);

            DeletedHomeworkTransferResponse response = _mapper.Map<DeletedHomeworkTransferResponse>(homeworkTransfer);
            return response;
        }
    }
}