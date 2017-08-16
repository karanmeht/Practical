using ManagemantSystem.Models;
using ManagemantSystem.ViewModels;
using System.Threading.Tasks;

namespace ManagemantSystem.Repository.RepositoryAccount
{
    public interface IAccountRepository
    {
        Task<bool> CreateUser(RegistrationViewModel registration);
        Task<bool> Login(LoginViewModel LoginModel);
    }
}
