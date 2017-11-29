using ManagementSystem.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Services.Description;

namespace ManagementSystem.Models.Employee
{
    public class Employee : BaseModel
    {
        [Required(ErrorMessage = "Name Must be required")]
        public string Name { get; set; }

        [Range(15, uint.MaxValue, ErrorMessage = "Age should be 18 or  greater")]
        [Required(ErrorMessage = "Age Must be required")]
        //[MinLength(18,ErrorMessage ="Age must be greater than 18"]
        //[MaxLength(60,ErrorMessage ="Age must be less then 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Date of birth Must be required")]
        [Display(Name = "DOB")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Phone number Must be required")]
        [Phone]
        public string Phone { get; set; }
        public Countries Country { get; set; }
    }
}