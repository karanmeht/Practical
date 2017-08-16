using ManagemantSystem.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagemantSystem.Models.Employee
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Genders Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CreateByUserId { get; set; }

        [ForeignKey("CreateByUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
