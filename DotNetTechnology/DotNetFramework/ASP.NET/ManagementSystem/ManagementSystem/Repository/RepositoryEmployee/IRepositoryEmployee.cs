using ManagementSystem.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Repository.RepositoryEmployee
{
    public interface IRepositoryEmployee
    {
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<bool> IsEmployeeExist(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task RemoveEmployeeAsync(Employee employee);
    }
}