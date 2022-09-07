using System.ComponentModel.DataAnnotations;

namespace CMPG323_Project_2_33642958.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
