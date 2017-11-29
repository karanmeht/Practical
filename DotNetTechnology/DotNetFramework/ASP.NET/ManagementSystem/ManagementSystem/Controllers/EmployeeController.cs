using ManagementSystem.Models.Employee;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementSystem.Repository.RepositoryEmployee;

namespace ManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepositoryEmployee _repositoryEmployee;

        public EmployeeController(IRepositoryEmployee repositoryEmployee)
        {
            _repositoryEmployee = repositoryEmployee;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {      
            return View(await _repositoryEmployee.GetAllEmployee());
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }

        public async Task<ActionResult> CreateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _repositoryEmployee.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> UpdateEmployee(int id)
        {
            if (ModelState.IsValid)
            {
                var getData = await _repositoryEmployee.GetEmployeeById(id);
                ViewBag.dob = getData.DateOfBirth.Date.ToString("MM/dd/yyyy");
                return View(getData);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateEmployee(Employee employee, int id)
        {
            if (ModelState.IsValid)
            {
                if (await _repositoryEmployee.IsExistsEmployee(id))
                {
                    await _repositoryEmployee.UpdateEmployee(employee);
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Something went wrong, Please try again!");
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            if (ModelState.IsValid)
            {
                return View(await _repositoryEmployee.GetEmployeeById(id));
            }
            ModelState.AddModelError("", "Something went wrong, Please try again!");
            return View();
        }

        [HttpPost]
        [ActionName("DeleteEmployee")]
        public async Task<ActionResult> DeleteEmployeeConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                Employee employee = await _repositoryEmployee.GetEmployeeById(id);
                if (employee != null)
                {
                    await _repositoryEmployee.RemoveEmployee(employee);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Something went wrong, Please try again!");
            return View();
        }
    }
}