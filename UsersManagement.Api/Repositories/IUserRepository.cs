using System.Collections.Concurrent;
using UsersManagement.Api.Models;

namespace UsersManagement.Api.Repositories
{
    public interface IUserRepository
    {
        ConcurrentDictionary<int, User> Users { get; }
    }
}
