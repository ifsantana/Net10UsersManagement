using System.ComponentModel.DataAnnotations;

namespace UsersManagement.Api.Models
{
    public record User(
        int Id,
        [Required, MinLength(3)] string Name,
        [Required, EmailAddress] string Email,
        [Required] int Age
    );
}
