using Application.Features.Homework.Commands.Create;
using Application.Features.Homework.Commands.Delete;
using Application.Features.Homework.Commands.Update;
using Application.Features.Homework.Queries.GetById;
using Application.Features.Homework.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Homework.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Domain.Entities.Homework, CreateHomeworkCommand>().ReverseMap();
        CreateMap<Domain.Entities.Homework, CreatedHomeworkResponse>().ReverseMap();
        CreateMap<Domain.Entities.Homework, UpdateHomeworkCommand>().ReverseMap();
        CreateMap<Domain.Entities.Homework, UpdatedHomeworkResponse>().ReverseMap();
        CreateMap<Domain.Entities.Homework, DeleteHomeworkCommand>().ReverseMap();
        CreateMap<Domain.Entities.Homework, DeletedHomeworkResponse>().ReverseMap();
        CreateMap<Domain.Entities.Homework, GetByIdHomeworkResponse>().ReverseMap();
        CreateMap<Domain.Entities.Homework, GetListHomeworkListItemDto>().ReverseMap();
        CreateMap<IPaginate<Domain.Entities.Homework>, GetListResponse<GetListHomeworkListItemDto>>().ReverseMap();
    }
}