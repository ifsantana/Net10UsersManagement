using System.Collections.Concurrent;
using UsersManagement.Api.Models;

namespace UsersManagement.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        public ConcurrentDictionary<int, User> Users { get; }
            = new ConcurrentDictionary<int, User>();
    }
}
