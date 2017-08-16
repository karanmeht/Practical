using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementSystem.Models.Employee;
using ManagementSystem.Models;
using System.Data.Entity;
using System.Linq;


namespace ManagementSystem.Repository.RepositoryEmployee
{
    public class RepositoryEmployee : IRepositoryEmployee
    {
        private readonly ManagementSystemModel _context;

        public RepositoryEmployee(ManagementSystemModel context)
        {
            _context = context;
        }

        public async Task AddEmployee(Employee employee)
        {
            employee.CreateDateTime = DateTime.UtcNow;
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return (await _context.Employee.ToListAsync());
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            //var temp = (from e in Employee where e.id == id select e);
            return (await _context.Employee.FirstOrDefaultAsync(e => e.Id == id));
        }

        public async Task<bool> IsEmployeeExist(int id)
        {
            return (await _context.Employee.AnyAsync(e => e.Id == id));
        }

        public async Task RemoveEmployeeAsync(Employee employee)
        {
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            employee.UpdateDateTime = DateTime.UtcNow;
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}