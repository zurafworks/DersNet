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

namespace Application.Features.HomeworkTransfers.Commands.Create;

public class CreateHomeworkTransferCommand : IRequest<CreatedHomeworkTransferResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public int HomeworkId { get; set; }
    public int StudentId { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Description { get; set; }
    public string Attachment { get; set; }
    public DateTime TransferDate { get; set; }

    public string[] Roles => [Admin, Write, HomeworkTransfersOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetHomeworkTransfers"];

    public class CreateHomeworkTransferCommandHandler : IRequestHandler<CreateHomeworkTransferCommand, CreatedHomeworkTransferResponse>
    {
        private readonly IMapper _mapper;
        private readonly IHomeworkTransferRepository _homeworkTransferRepository;
        private readonly HomeworkTransferBusinessRules _homeworkTransferBusinessRules;

        public CreateHomeworkTransferCommandHandler(IMapper mapper, IHomeworkTransferRepository homeworkTransferRepository,
                                         HomeworkTransferBusinessRules homeworkTransferBusinessRules)
        {
            _mapper = mapper;
            _homeworkTransferRepository = homeworkTransferRepository;
            _homeworkTransferBusinessRules = homeworkTransferBusinessRules;
        }

        public async Task<CreatedHomeworkTransferResponse> Handle(CreateHomeworkTransferCommand request, CancellationToken cancellationToken)
        {
            HomeworkTransfer homeworkTransfer = _mapper.Map<HomeworkTransfer>(request);

            await _homeworkTransferRepository.AddAsync(homeworkTransfer);

            CreatedHomeworkTransferResponse response = _mapper.Map<CreatedHomeworkTransferResponse>(homeworkTransfer);
            return response;
        }
    }
}