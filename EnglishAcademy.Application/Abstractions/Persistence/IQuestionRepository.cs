using System;
using EnglishAcademy.Domain.Entities;

namespace EnglishAcademy.Application.Abstractions.Persistence;

public interface IQuestionRepository
{
    Task<IReadOnlyList<Question>> GetByIds(IEnumerable<Guid> ids);
}
