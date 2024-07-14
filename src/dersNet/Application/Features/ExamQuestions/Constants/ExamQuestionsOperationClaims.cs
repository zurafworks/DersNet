using NArchitecture.Core.Security.Attributes;

namespace Application.Features.ExamQuestions.Constants;

[OperationClaimConstants]
public static class ExamQuestionsOperationClaims
{
    private const string _section = "ExamQuestions";

    public const string Admin = $"{_section}.Admin";

    public const string Read = $"{_section}.Read";
    public const string Write = $"{_section}.Write";

    public const string Create = $"{_section}.Create";
    public const string Update = $"{_section}.Update";
    public const string Delete = $"{_section}.Delete";
    public const string GetListQuestinWithExam = $"{_section}.GetListQuestinWithExam";
}
