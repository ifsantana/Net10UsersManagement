using System.Collections.Concurrent;
using UsersManagement.Api.Controllers;
using UsersManagement.Api.Models;

namespace UsersManagement.Api.Repositories
{
    public interface IUserRepository
    {
        List<User> ListAll();
        User? GetById(string id);
        User Create(User user);
        bool Delete(string id);
    }
}
