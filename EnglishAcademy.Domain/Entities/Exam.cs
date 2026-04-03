namespace EnglishAcademy.Domain.Entities;

public class Exam
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid ExamTypeId { get; init; }
    public Exam(Guid userId, Guid examTypeId)
    {
        if (userId == Guid.Empty) throw new ArgumentException("UserId cannot be empty");
        if (examTypeId == Guid.Empty) throw new ArgumentException("ExamTypeId cannot be empty");

        Id = Guid.CreateVersion7();
        UserId = userId;
        ExamTypeId = examTypeId;
    }
}
