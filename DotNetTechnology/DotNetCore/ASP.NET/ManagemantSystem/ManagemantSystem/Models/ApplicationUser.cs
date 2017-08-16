using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace ManagemantSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
