
namespace EnglishAcademy.Domain.Entities;

public class ExamAnswer
{
    public Guid ExamId { get; init; }
    public Guid QuestionId { get; init; }
    public Guid AnswerId { get; init; }

    public ExamAnswer(Guid examId, Guid questionId, Guid answerId)
    {
        if (Guid.Empty == examId) throw new ArgumentException("examId cannot be empty");
        if (Guid.Empty == questionId) throw new ArgumentException("questionId cannot be empty");
        if (Guid.Empty == answerId) throw new ArgumentException("answerId cannot be empty");

        ExamId = examId;
        QuestionId = questionId;
        AnswerId = answerId;
    }

}
