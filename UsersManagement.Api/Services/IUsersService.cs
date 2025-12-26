using UsersManagement.Api.Models;

namespace UsersManagement.Api.Services
{
    public interface IUsersService
    {
        List<UserDto> ListAll();
        UserDto? GetById(string id);
        UserDto Create(UserDto user);
        bool Delete(string id);
    }
}
