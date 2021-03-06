using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
         public string UserName { get; set; }

         [Required]
         [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters long.")]
         public string Password { get; set; }
    }
}