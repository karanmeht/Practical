using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManagemantSystem.Models
{
    public class ManagemantContext : IdentityDbContext<ApplicationUser>
    {
        public ManagemantContext(DbContextOptions Options) : base(Options)
        {

        }
        
        public DbSet<Employee.Employee> Employee { get; set; }
    }
}