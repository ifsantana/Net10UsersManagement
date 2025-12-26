
using UsersManagement.Api.Controllers;
using UsersManagement.Api.Models;
using UsersManagement.Api.Repositories;

namespace UsersManagement.Api.Services
{
    public class UsersService : IUsersService
    {
        private IUserRepository _userRepository;

        public UsersService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public UserDto Create(UserDto user)
        {
            return _userRepository.Create(new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Age = user.Age
            }) switch
            {
                User createdUser => new UserDto
                (
                    createdUser.Id,
                    createdUser.Name,
                    createdUser.Email,
                    createdUser.Age
                ),
                _ => throw new Exception("User creation failed")
            };
        }

        public bool Delete(string id)
        {
            return _userRepository.Delete(id);
        }

        public UserDto? GetById(string id)
        {
           var user = _userRepository.GetById(id);
           
           return user != null ?  new UserDto
           (
               user.Id,
               user.Name,
               user.Email,
               user.Age
           ) : null;
        }

        public List<UserDto> ListAll()
        {
           var users = _userRepository.ListAll();
           
           return users.Select(user => new UserDto
           (
               user.Id,
               user.Name,
               user.Email,
               user.Age
           )).ToList();
        }
    }
}
