using System;

namespace EnglishAcademy.Domain.Entities;

public class Answer
{
    public Guid Id { get; init; }
    public string Description { get; set; }
    public bool IsCorrect { get; set; }
    public Guid QuestionId { get; init; }

    public ICollection<ExamAnswer> ExamAnswers = new List<ExamAnswer>();

    public Answer(string description, bool isCorrect, Guid questionId)
    {
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("description cannot be null or white space");
        if (questionId == Guid.Empty) throw new ArgumentException("UserId cannot be empty");

        Description = description;
        IsCorrect = isCorrect;
        QuestionId = questionId;

    }

}
