using System;
using EnglishAcademy.Domain.Entities;

namespace EnglishAcademy.Application.Abstractions.Persistence;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User> GetByIdAsync(Guid id);
}
