
namespace EnglishAcademy.Domain.Entities;

public class ExamQuestion
{
    public Guid ExamId { get; init; }
    public Guid QuestionId { get; init; }

    public ExamQuestion(Guid examId, Guid questionId)
    {
        if (Guid.Empty == examId) throw new ArgumentException("examId cannot be empty");
        if (Guid.Empty == questionId) throw new ArgumentException("questionId cannot be empty");

        ExamId = examId;
        QuestionId = questionId;
    }
}
