using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagemantSystem.Repository.RepositoryAccount;
using ManagemantSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using ManagemantSystem.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagemantSystem.Controllers
{
    //[Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        //public AccountController(UserManager<ApplicationUser> userManager)
        //{
        //    _userManager = userManager;
        //}
        public AccountController(IAccountRepository accountRepository, UserManager<ApplicationUser> userManager)
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult RegistrationView(int id)
        {

            return View("Registration");
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel user)
        {
            var result = await _accountRepository.CreateUser(user);
            if (result)
            {
                return RedirectToAction("Dashboard", "Employee");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var Result = await _accountRepository.Login(model);
                if (Result)
                {
                    // return RedirectToAction(returnUrl);
                    return RedirectToLocal(returnUrl);
                    // return RedirectToAction("Dashboard", "Employee");
                }
            }
            ModelState.AddModelError("", "Invalid Login Attempt");
            return View();
        }

        //public IActionResult Logout()
        //{
        //    var AutheticationManager = HttpContext.Authentication.SignOutAsync;
        //    return View();
        //}

        /// <summary>
        /// this method is used to redirect to any local url link
        /// </summary>
        /// <param name="returnUrl">string type of url</param>
        /// <returns>redirect to a specific url</returns>
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(EmployeeController.Dashboard), "Employee");
            }
        }
        [HttpGet]
        public async Task<IActionResult> DeleteUser(string email)
        {
            //var applicationUser = await _userManager.FindByEmailAsync(email);
            //using (var transaction = context.Database.BeginTransaction())
            //{
            //    foreach (var login in logins.ToList())
            //    {
            //        await _userManager.RemoveLoginAsync(login.UserId, new UserLoginInfo(login.LoginProvider, login.ProviderKey));
            //    }

            //    if (rolesForUser.Count() > 0)
            //    {
            //        foreach (var item in rolesForUser.ToList())
            //        {
            //            // item should be the name of the role
            //            var result = await _userManager.RemoveFromRoleAsync(user.Id, item);
            //        }
            //    }
            //    await _userManager.DeleteAsync(applicationUser);
            //    // var login = applicationUser.Logins;
            //    // DbTransaction.commit();
            return RedirectToAction("Login");
        }
    }
}
