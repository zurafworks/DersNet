using Application.Features.HomeworkTransfers.Commands.Create;
using Application.Features.HomeworkTransfers.Commands.Delete;
using Application.Features.HomeworkTransfers.Commands.Update;
using Application.Features.HomeworkTransfers.Queries.GetById;
using Application.Features.HomeworkTransfers.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.HomeworkTransfers.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<HomeworkTransfer, CreateHomeworkTransferCommand>().ReverseMap();
        CreateMap<HomeworkTransfer, CreatedHomeworkTransferResponse>().ReverseMap();
        CreateMap<HomeworkTransfer, UpdateHomeworkTransferCommand>().ReverseMap();
        CreateMap<HomeworkTransfer, UpdatedHomeworkTransferResponse>().ReverseMap();
        CreateMap<HomeworkTransfer, DeleteHomeworkTransferCommand>().ReverseMap();
        CreateMap<HomeworkTransfer, DeletedHomeworkTransferResponse>().ReverseMap();
        CreateMap<HomeworkTransfer, GetByIdHomeworkTransferResponse>().ReverseMap();
        CreateMap<HomeworkTransfer, GetListHomeworkTransferListItemDto>().ReverseMap();
        CreateMap<IPaginate<HomeworkTransfer>, GetListResponse<GetListHomeworkTransferListItemDto>>().ReverseMap();
    }
}