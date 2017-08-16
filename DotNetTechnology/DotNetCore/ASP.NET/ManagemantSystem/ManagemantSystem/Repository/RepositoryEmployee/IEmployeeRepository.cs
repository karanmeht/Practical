using ManagemantSystem.Models;
using ManagemantSystem.Models.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagemantSystem.Repository.RepositoryEmployee
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<bool> IsEmployeeExist(int id);
        Task AddEmployee(Employee employee,string userId);
        Task UpdateEmployeeAsync(Employee employee);
        Task RemoveEmployeeAsync(Employee employee);

    }
}
