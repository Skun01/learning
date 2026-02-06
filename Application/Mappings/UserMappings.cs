using Application.DTOs.Auth;
using Application.DTOs.User;
using Domain.Entities;

namespace Application.Mappings;

public static class UserMappings
{
    public static UserDTO ToDTO(this User user)
    {
        return new UserDTO()
        {
            Id = user.Id,
            Username = user.Username
        };
    }
}
