using System.ComponentModel.DataAnnotations;
using Optitime.Classes;
namespace Optitime.Api
{
    public class UserDto
    {

        public Guid Id { get; set; }

        [MaxLength(32)]
        [Required]
        public string Login { get; set; }


        [MaxLength(32)]
        [Required]
        public string Name { get; set; }
        [MaxLength(32)]
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [MaxLength(128)]
        [Required]
        public string Email { get; set; }

        public UserDto() { }
        public UserDto(User user) {
            this.Id = user.Id;
            this.Login = user.Login;
            this.Name = user.Name;
            this.LastName = user.LastName;
            this.Email = user.Email;
        }
    }
}
