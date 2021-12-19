using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email is mandatory")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
