using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.Questions.Queries.GetListWithChoices;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class QuestionRepository : EfRepositoryBase<Question, Guid, BaseDbContext>, IQuestionRepository
{
    public QuestionRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<Question> AddQuestionWithChoices(Question question, List<Choice> choices, CancellationToken cancellationToken)
    {
        var createdDate = DateTime.UtcNow;
        question.CreatedDate = createdDate;
        var questionId = Context.AddAsync(question, cancellationToken).GetAwaiter().GetResult().Entity.Id;

        foreach (var choice in choices)
        {
            choice.QuestionId = questionId;
            choice.CreatedDate = createdDate;
        }

        Context.AddRangeAsync(choices, cancellationToken);

        await Context.SaveChangesAsync(cancellationToken);
        return question;
    }

    public async Task<IPaginate<GetListQuestionWithChoicesListItemDto>> GetListWithChoicesPaginateAsync(int index, int size, CancellationToken cancellationToken)
    {
        var query = from question in Context.Questions
                    join lesson in Context.Lessons on question.LessonId equals lesson.Id
                    join choice in Context.Choices on question.Id equals choice.QuestionId into choicesGroup
                    select new GetListQuestionWithChoicesListItemDto
                    {
                        Id = question.Id,
                        LessonId = question.LessonId,
                        LessonName = lesson.Title,
                        Text = question.Text ?? string.Empty,
                        Image = question.Image ?? "~/images/course/default.jpg",
                        Answer = choicesGroup.FirstOrDefault(x => x.IsAnswer),
                        Choices = choicesGroup.ToList()
                    };
        return await query.ToPaginateAsync(index, size, cancellationToken: cancellationToken);
    }

    public async Task<Question> UpdateQuestionWithChoices(Question question, List<Choice> choices, CancellationToken cancellationToken)
    {
        question.UpdatedDate = DateTime.UtcNow;
        Context.Update(question);

        var newChoices = choices.Where(x => !x.UpdatedDate.HasValue && !x.DeletedDate.HasValue).ToList();
        var updateChoices = choices.Where(x => !newChoices.Select(n => n.Id).Contains(x.Id)).ToList();

        await Context.AddRangeAsync(newChoices, cancellationToken);
        //Context.UpdateRange(updateChoices, cancellationToken);
        updateChoices.ForEach(choice =>
        {
            Context.Update(choice);
        });

        await Context.SaveChangesAsync(cancellationToken);
        return question;
    }
}
