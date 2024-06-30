using Application.Features.HomeworkTransfers.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.HomeworkTransfers.Constants.HomeworkTransfersOperationClaims;

namespace Application.Features.HomeworkTransfers.Queries.GetList;

public class GetListHomeworkTransferQuery : IRequest<GetListResponse<GetListHomeworkTransferListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListHomeworkTransfers({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetHomeworkTransfers";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListHomeworkTransferQueryHandler : IRequestHandler<GetListHomeworkTransferQuery, GetListResponse<GetListHomeworkTransferListItemDto>>
    {
        private readonly IHomeworkTransferRepository _homeworkTransferRepository;
        private readonly IMapper _mapper;

        public GetListHomeworkTransferQueryHandler(IHomeworkTransferRepository homeworkTransferRepository, IMapper mapper)
        {
            _homeworkTransferRepository = homeworkTransferRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListHomeworkTransferListItemDto>> Handle(GetListHomeworkTransferQuery request, CancellationToken cancellationToken)
        {
            IPaginate<HomeworkTransfer> homeworkTransfers = await _homeworkTransferRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListHomeworkTransferListItemDto> response = _mapper.Map<GetListResponse<GetListHomeworkTransferListItemDto>>(homeworkTransfers);
            return response;
        }
    }
}