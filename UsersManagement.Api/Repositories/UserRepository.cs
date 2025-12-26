using Microsoft.EntityFrameworkCore;
using UsersManagement.Api.Controllers;

namespace UsersManagement.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private PgDataContext _context;

        public UserRepository(PgDataContext pgDataContext)
        {
                _context = pgDataContext;
        }

        public User Create(User user)
        {
            _context.users.Add(user);

            return _context.SaveChanges() > 0 ? user : throw new DbUpdateException($"Error when trying to save user with email {user.Email}");
        }

        public bool Delete(string id)
        {
            var result = _context.users.Where(user => user.Id.Equals(id)).ExecuteDelete();

            return result > 0;
        }

        public User? GetById(string id)
        {
            return _context.users.Where(user => user.Id.Equals(id)).FirstOrDefault();
        }

        public List<User> ListAll()
        {
            return _context.users.ToList();
        }
    }
}
