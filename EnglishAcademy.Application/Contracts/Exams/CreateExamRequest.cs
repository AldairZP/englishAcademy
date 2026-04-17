using System;

namespace EnglishAcademy.Application.Contracts.Exams;

public sealed record CreateExamRequest(Guid userId, Guid examTypeId);
