using ManagemantSystem.Models;
using ManagemantSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagemantSystem.Repository.RepositoryAccount
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountRepository(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> CreateUser(RegistrationViewModel registration)
        { 
            var User = new ApplicationUser
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                Email = registration.Email,
                DOB = registration.DOB,
                PhoneNumber = registration.PhoneNumber,
                UserName=registration.Email
            };

            var result = await _userManager.CreateAsync(User,registration.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Login(LoginViewModel LoginModel)
        {
            var Verify = await _signInManager.PasswordSignInAsync(LoginModel.Email, LoginModel.Password, LoginModel.RememberMe,false);
            if (Verify.Succeeded)
            {
                return true;
            }
            return false;
        }

        
    }
}
