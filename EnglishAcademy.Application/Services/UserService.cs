using System;
using EnglishAcademy.Application.Abstractions.Persistence;

namespace EnglishAcademy.Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


}
