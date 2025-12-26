using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersManagement.Api.Controllers
{
    public class User
    {
       [Column("id")]
       public string Id { get; set; }

       [Required, MinLength(3)]
        [Column("name")]
        public string Name { get; set; }

        [Required, EmailAddress]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }
    }
}
