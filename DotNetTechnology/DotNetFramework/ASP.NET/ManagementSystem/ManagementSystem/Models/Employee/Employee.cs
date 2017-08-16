using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models.Employee
{
    public class Employee : BaseModel
    {
        [Required(ErrorMessage = "Name is Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Mobile No")]
        [Required(ErrorMessage = "Mobile number is Required")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Country Name is Required")]
        public string Country { get; set; }
    }
}