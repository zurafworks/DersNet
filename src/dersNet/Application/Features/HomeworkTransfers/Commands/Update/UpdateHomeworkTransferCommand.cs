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
using Domain.Enums;
using static Application.Features.HomeworkTransfers.Constants.HomeworkTransfersOperationClaims;

namespace Application.Features.HomeworkTransfers.Commands.Update;

public class UpdateHomeworkTransferCommand : IRequest<UpdatedHomeworkTransferResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public int HomeworkId { get; set; }
    public int StudentId { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; }
    public DateTime TransferDate { get; set; }

    public string[] Roles => [Admin, Write, HomeworkTransfersOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomeworkTransfers"];

    public class UpdateHomeworkTransferCommandHandler : IRequestHandler<UpdateHomeworkTransferCommand, UpdatedHomeworkTransferResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkTransferRepository _homeworkTransferRepository;
        private readonly HomeworkTransferBusinessRules _homeworkTransferBusinessRules;

        public UpdateHomeworkTransferCommandHandler(IMapper mapper, IHomeworkTransferRepository homeworkTransferRepository,
                                         HomeworkTransferBusinessRules homeworkTransferBusinessRules)
        {
            _mapper = mapper;
            _homeworkTransferRepository = homeworkTransferRepository;
            _homeworkTransferBusinessRules = homeworkTransferBusinessRules;
        }

        public async Task<UpdatedHomeworkTransferResponse> Handle(UpdateHomeworkTransferCommand request, CancellationToken cancellationToken)
        {
            HomeworkTransfer? homeworkTransfer = await _homeworkTransferRepository.GetAsync(predicate: ht => ht.Id == request.Id, cancellationToken: cancellationToken);
            await _homeworkTransferBusinessRules.HomeworkTransferShouldExistWhenSelected(homeworkTransfer);
            homeworkTransfer = _mapper.Map(request, homeworkTransfer);

            await _homeworkTransferRepository.UpdateAsync(homeworkTransfer!);

            UpdatedHomeworkTransferResponse response = _mapper.Map<UpdatedHomeworkTransferResponse>(homeworkTransfer);
            return response;
        }
    }
}