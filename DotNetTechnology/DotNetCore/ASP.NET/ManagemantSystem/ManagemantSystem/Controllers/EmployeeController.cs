using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagemantSystem.Repository.RepositoryEmployee;
using ManagemantSystem.Models.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ManagemantSystem.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagemantSystem.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        #region Private Members

        private readonly IEmployeeRepository _employeeRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        #endregion

        #region Constructor

        public EmployeeController(IEmployeeRepository employeeRepository, UserManager<ApplicationUser> userManager)
        {
            _employeeRepository = employeeRepository;
            _userManager = userManager;
        }
        #endregion

        #region Employee API

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Dashboard()
        {
            IEnumerable<Employee> Emp = await _employeeRepository.GetAllEmployee();
            return View("Dashboard", Emp);
        }

        [HttpGet]
        public async Task<IActionResult> GetSingleEmployee(int id)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(await _employeeRepository.GetEmployeeById(id));
            return View("Dashboard", employee);
        }

        [HttpGet]
        public IActionResult AddEmployeeView()
        {
            Employee Emp = new Employee();
            return View("AddEmployee",Emp);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var applicationUser = await _userManager.FindByEmailAsync(User.Identity.Name);

                await _employeeRepository.AddEmployee(employee,applicationUser.Id);
                return RedirectToAction("Dashboard", "Employee");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployeeViewAsync(int id)
        {
            Employee employee = await _employeeRepository.GetEmployeeById(id);
            if (employee != null)
            {
                return View("UpdateEmployee", employee);
            }
            return View("Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(Employee employee, int id)
        {
            if (ModelState.IsValid)
            {
                await _employeeRepository.UpdateEmployeeAsync(employee);
                return RedirectToAction("Dashboard", "Employee");
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(int Id)
        {
            Employee employee = await _employeeRepository.GetEmployeeById(Id);
            if (employee != null)
            {
                await _employeeRepository.RemoveEmployeeAsync(employee);
                return RedirectToAction("Dashboard", "Employee");
            }
            return BadRequest();
        }
        #endregion
    }
}
