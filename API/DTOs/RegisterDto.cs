using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username {get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]  //max is 8 and min is 4
        public string Password {get; set; }
    }
}