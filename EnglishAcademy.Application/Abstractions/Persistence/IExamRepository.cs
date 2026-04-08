using System;
using EnglishAcademy.Domain.Entities;

namespace EnglishAcademy.Application.Abstractions.Persistence;

public interface IExamRepository
{
    Task<Exam> AddAsync(Exam exam);
    

}
