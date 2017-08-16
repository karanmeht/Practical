using System.ComponentModel.DataAnnotations;

namespace ManagemantSystem.ViewModels
{
    public class RegistrationViewModel
    {
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        public string Password { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
