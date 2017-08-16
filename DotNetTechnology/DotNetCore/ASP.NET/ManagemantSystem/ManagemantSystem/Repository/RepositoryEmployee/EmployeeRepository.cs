using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagemantSystem.Models.Employee;
using ManagemantSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ManagemantSystem.Repository.RepositoryEmployee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Private Member
        private readonly ManagemantContext _context;
        #endregion

        #region Constructor

        public EmployeeRepository(ManagemantContext Context)
        {
            _context = Context;
        }
        #endregion

        #region Public Method
        public async Task AddEmployee(Employee employee, string userId)
        {

            employee.CreateDateTime = DateTime.UtcNow;
            employee.CreateByUserId = userId;
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return (await _context.Employee.ToListAsync());
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
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
            _context.Employee.Update(employee);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
