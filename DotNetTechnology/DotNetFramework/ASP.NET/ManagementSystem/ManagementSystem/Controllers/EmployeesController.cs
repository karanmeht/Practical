using ManagementSystem.Models.Employee;
using ManagementSystem.Repository.RepositoryEmployee;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IRepositoryEmployee _repositoryEmployee;

        public EmployeesController(IRepositoryEmployee repositoryEmployee)
        {
            _repositoryEmployee = repositoryEmployee;
        }

        // GET: Employees
        public ActionResult Index()
        {
            return RedirectToAction("Dashboard");
        }
        public async Task<ActionResult> Details(int id)
        {
            return View(await _repositoryEmployee.GetEmployeeById(id));
        }
        public async Task<ActionResult> Dashboard()
        {
            return View(await _repositoryEmployee.GetAllEmployee());
        }
        
        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public async Task<ActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
                return View();
            await _repositoryEmployee.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        // GET: Employees/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _repositoryEmployee.GetEmployeeById(id));
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return View();
            await _repositoryEmployee.UpdateEmployeeAsync(employee);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _repositoryEmployee.GetEmployeeById(id));
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                Employee employee = await _repositoryEmployee.GetEmployeeById(id);
                if (employee!=null)
                {
                    await _repositoryEmployee.RemoveEmployeeAsync(employee);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Something went wrong. please try again!");
            return View();
        }
    }
}
