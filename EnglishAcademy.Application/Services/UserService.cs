using System.Runtime.InteropServices;
using EnglishAcademy.Application.Abstractions.Persistence;
using EnglishAcademy.Application.Contracts;
using EnglishAcademy.Application.Contracts.Users;
using EnglishAcademy.Domain.Entities;

namespace EnglishAcademy.Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> CreateAsync(CreateUserRequest createUserRequest)
    {
        var newUser = new User(createUserRequest.UserName, createUserRequest.Password);
        await _userRepository.AddAsync(newUser);

        return new UserDto(newUser.Id, newUser.UserName);
    }


}
