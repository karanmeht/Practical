//using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementSystem.Models.Employee;
using ManagementSystem.Models;
using System.Data.Entity;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ManagementSystem.Repository.RepositoryEmployee
{
    public class RepositoryEmployee : IRepositoryEmployee
    {
        private readonly ManagementSystemDbContext _dbContext;

        public RepositoryEmployee(ManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddEmployee(Employee employee)
        {
            employee.CreateDateTime = DateTime.UtcNow;
            _dbContext.Employee.Add(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {

            return (await _dbContext.Employee.ToListAsync());
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return (await _dbContext.Employee.FirstOrDefaultAsync(emp => emp.Id == id));
        }

        public async Task<bool> IsExistsEmployee(int id)
        {
            return (await _dbContext.Employee.AnyAsync(emp => emp.Id == id));
        }

        public async Task RemoveEmployee(Employee employee)
        {
            _dbContext.Employee.Remove(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Employee employee)
        {
            employee.UpdateDateTime = DateTime.UtcNow;
            _dbContext.Entry(employee).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}