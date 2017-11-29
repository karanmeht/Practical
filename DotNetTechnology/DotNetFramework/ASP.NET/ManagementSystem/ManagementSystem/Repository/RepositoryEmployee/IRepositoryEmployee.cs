using ManagementSystem.Models.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementSystem.Repository.RepositoryEmployee
{
    public interface IRepositoryEmployee
    {
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task AddEmployee(Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task<bool> IsExistsEmployee(int id);
        Task UpdateEmployee(Employee employee);
        Task RemoveEmployee(Employee employee);
    }
}