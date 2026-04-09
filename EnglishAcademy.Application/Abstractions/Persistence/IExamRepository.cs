using System;
using EnglishAcademy.Domain.Entities;

namespace EnglishAcademy.Application.Abstractions.Persistence;

public interface IExamRepository
{
    Task AddAsync(Exam exam);
    Task AddQuestionsAsync(Guid examId, IReadOnlyCollection<Guid> questionIds);
    Task AddAnswersAsync(IReadOnlyCollection<ExamAnswer> examAnswers);
    Task<Exam> GetByIdAsync(Guid id);
}
