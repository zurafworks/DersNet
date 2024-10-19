using Application.Features.Questions.Commands.Create;
using Application.Features.Questions.Commands.Delete;
using Application.Features.Questions.Commands.Update;
using Application.Features.Questions.Queries.GetById;
using Application.Features.Questions.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Questions.Queries.GetListWithChoices;

namespace Application.Features.Questions.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Question, CreateQuestionCommand>().ReverseMap();
        CreateMap<Question, CreatedQuestionResponse>().ReverseMap();
        CreateMap<Question, CreateQuestionWithChoicesCommand>().ReverseMap();
        CreateMap<Question, CreatedQuestionWithChoicesResponse>().ReverseMap();
        CreateMap<Question, UpdateQuestionCommand>().ReverseMap();
        CreateMap<Question, UpdatedQuestionResponse>().ReverseMap();
        CreateMap<Question, UpdateQuestionWithChoicesCommand>().ReverseMap();
        CreateMap<Question, UpdatedQuestionWithChoicesResponse>().ReverseMap();
        CreateMap<Question, DeleteQuestionCommand>().ReverseMap();
        CreateMap<Question, DeletedQuestionResponse>().ReverseMap();
        CreateMap<Question, GetByIdQuestionResponse>().ReverseMap();
        CreateMap<Question, GetListQuestionListItemDto>().ReverseMap();

        //CreateMap<GetListQuestionWithChoicesListItemDto, GetListQuestionWithChoicesListItemDto>()
        //    .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.LessonName))
        //    .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices))
        //    .ForMember(dest => dest.Answer, opt => opt.MapFrom(src => src.Choices.FirstOrDefault(c => c.IsAnswer)));

        CreateMap<Paginate<GetListQuestionWithChoicesListItemDto>, GetListResponse<GetListQuestionWithChoicesListItemDto>>();
    }
}
