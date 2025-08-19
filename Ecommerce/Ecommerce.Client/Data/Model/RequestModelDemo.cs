using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.Model
{
    public class RequestModelDemo
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
