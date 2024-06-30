using Application.Features.Auth.Constants;
using Application.Features.OperationClaims.Constants;
using Application.Features.UserOperationClaims.Constants;
using Application.Features.Users.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NArchitecture.Core.Security.Constants;
using Application.Features.Choices.Constants;
using Application.Features.Courses.Constants;
using Application.Features.Exams.Constants;
using Application.Features.ExamQuestions.Constants;
using Application.Features.Groups.Constants;
using Application.Features.GroupUsers.Constants;
using Application.Features.Homework.Constants;
using Application.Features.HomeworkTransfers.Constants;
using Application.Features.Lessons.Constants;
using Application.Features.Packs.Constants;
using Application.Features.Questions.Constants;
using Application.Features.Sessions.Constants;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasData(_seeds);

        builder.HasBaseType((string)null!);
    }

    public static int AdminId => 1;
    private IEnumerable<OperationClaim> _seeds
    {
        get
        {
            yield return new() { Id = AdminId, Name = GeneralOperationClaims.Admin };

            IEnumerable<OperationClaim> featureOperationClaims = getFeatureOperationClaims(AdminId);
            foreach (OperationClaim claim in featureOperationClaims)
                yield return claim;
        }
    }

#pragma warning disable S1854 // Unused assignments should be removed
    private IEnumerable<OperationClaim> getFeatureOperationClaims(int initialId)
    {
        int lastId = initialId;
        List<OperationClaim> featureOperationClaims = new();

        #region Auth
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = AuthOperationClaims.Admin },
                new() { Id = ++lastId, Name = AuthOperationClaims.Read },
                new() { Id = ++lastId, Name = AuthOperationClaims.Write },
                new() { Id = ++lastId, Name = AuthOperationClaims.RevokeToken },
            ]
        );
        #endregion

        #region OperationClaims
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Admin },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Read },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Write },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Create },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Update },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Delete },
            ]
        );
        #endregion

        #region UserOperationClaims
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Admin },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Read },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Write },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Create },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Update },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Delete },
            ]
        );
        #endregion

        #region Users
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = UsersOperationClaims.Admin },
                new() { Id = ++lastId, Name = UsersOperationClaims.Read },
                new() { Id = ++lastId, Name = UsersOperationClaims.Write },
                new() { Id = ++lastId, Name = UsersOperationClaims.Create },
                new() { Id = ++lastId, Name = UsersOperationClaims.Update },
                new() { Id = ++lastId, Name = UsersOperationClaims.Delete },
            ]
        );
        #endregion

        
        #region Choices
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Admin },
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Read },
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Write },
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Create },
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Update },
                new() { Id = ++lastId, Name = ChoicesOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Courses
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = CoursesOperationClaims.Admin },
                new() { Id = ++lastId, Name = CoursesOperationClaims.Read },
                new() { Id = ++lastId, Name = CoursesOperationClaims.Write },
                new() { Id = ++lastId, Name = CoursesOperationClaims.Create },
                new() { Id = ++lastId, Name = CoursesOperationClaims.Update },
                new() { Id = ++lastId, Name = CoursesOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Exams
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = ExamsOperationClaims.Admin },
                new() { Id = ++lastId, Name = ExamsOperationClaims.Read },
                new() { Id = ++lastId, Name = ExamsOperationClaims.Write },
                new() { Id = ++lastId, Name = ExamsOperationClaims.Create },
                new() { Id = ++lastId, Name = ExamsOperationClaims.Update },
                new() { Id = ++lastId, Name = ExamsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region ExamQuestions
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Admin },
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Read },
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Write },
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Create },
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Update },
                new() { Id = ++lastId, Name = ExamQuestionsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Groups
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = GroupsOperationClaims.Admin },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Read },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Write },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Create },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Update },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Groups
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = GroupsOperationClaims.Admin },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Read },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Write },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Create },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Update },
                new() { Id = ++lastId, Name = GroupsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region GroupUsers
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Admin },
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Read },
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Write },
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Create },
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Update },
                new() { Id = ++lastId, Name = GroupUsersOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Homework
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Admin },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Read },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Write },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Create },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Update },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region HomeworkTransfers
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Admin },
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Read },
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Write },
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Create },
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Update },
                new() { Id = ++lastId, Name = HomeworkTransfersOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Lessons
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = LessonsOperationClaims.Admin },
                new() { Id = ++lastId, Name = LessonsOperationClaims.Read },
                new() { Id = ++lastId, Name = LessonsOperationClaims.Write },
                new() { Id = ++lastId, Name = LessonsOperationClaims.Create },
                new() { Id = ++lastId, Name = LessonsOperationClaims.Update },
                new() { Id = ++lastId, Name = LessonsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Packs
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = PacksOperationClaims.Admin },
                new() { Id = ++lastId, Name = PacksOperationClaims.Read },
                new() { Id = ++lastId, Name = PacksOperationClaims.Write },
                new() { Id = ++lastId, Name = PacksOperationClaims.Create },
                new() { Id = ++lastId, Name = PacksOperationClaims.Update },
                new() { Id = ++lastId, Name = PacksOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Questions
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Admin },
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Read },
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Write },
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Create },
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Update },
                new() { Id = ++lastId, Name = QuestionsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Sessions
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = SessionsOperationClaims.Admin },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Read },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Write },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Create },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Update },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Sessions
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = SessionsOperationClaims.Admin },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Read },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Write },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Create },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Update },
                new() { Id = ++lastId, Name = SessionsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Homework
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Admin },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Read },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Write },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Create },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Update },
                new() { Id = ++lastId, Name = HomeworkOperationClaims.Delete },
            ]
        );
        #endregion
        
        return featureOperationClaims;
    }
#pragma warning restore S1854 // Unused assignments should be removed
}
