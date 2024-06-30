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
        CreateMap<Homework, CreateHomeworkCommand>().ReverseMap();
        CreateMap<Homework, CreatedHomeworkResponse>().ReverseMap();
        CreateMap<Homework, UpdateHomeworkCommand>().ReverseMap();
        CreateMap<Homework, UpdatedHomeworkResponse>().ReverseMap();
        CreateMap<Homework, DeleteHomeworkCommand>().ReverseMap();
        CreateMap<Homework, DeletedHomeworkResponse>().ReverseMap();
        CreateMap<Homework, GetByIdHomeworkResponse>().ReverseMap();
        CreateMap<Homework, GetListHomeworkListItemDto>().ReverseMap();
        CreateMap<IPaginate<Homework>, GetListResponse<GetListHomeworkListItemDto>>().ReverseMap();
    }
}