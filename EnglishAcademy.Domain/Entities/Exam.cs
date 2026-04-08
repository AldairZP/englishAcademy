namespace EnglishAcademy.Domain.Entities;

public class Exam
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid ExamTypeId { get; init; }

    public ICollection<ExamQuestion> ExamQuestions { get; private set; } = new List<ExamQuestion>();
    public ICollection<ExamAnswer> ExamAnswers { get; private set; } = new List<ExamAnswer>();

    public Exam(Guid userId, Guid examTypeId)
    {
        if (userId == Guid.Empty) throw new ArgumentException("UserId cannot be empty");
        if (examTypeId == Guid.Empty) throw new ArgumentException("ExamTypeId cannot be empty");

        Id = Guid.CreateVersion7();
        UserId = userId;
        ExamTypeId = examTypeId;
    }
}
