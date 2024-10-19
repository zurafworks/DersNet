using Domain.Entities;
using NArchitecture.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Queries.GetListWithChoices;
public class GetListQuestionWithChoicesListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }

    public string LessonName { get; set; }

    public string Text { get; set; }
    public string Image { get; set; }

    public Choice Answer { get; set; }

    public List<Choice> Choices { get; set; }
}
