using Homeworks_Exception.Helpers.Exceptions;
using Homeworks_Exception.Models;
using Homeworks_Exception.Services.Interfaces;

namespace Homeworks_Exception.Services
{
    internal class AccountService : IAccountService
    {
        private readonly IUserService _userService;

        public AccountService()
        {
            _userService = new UserService();
        }

        public bool SingIn(string email, string password)
        {
            User[] users = _userService.GetAll();
            User existUser = users.FirstOrDefault(m => m.Email == email && m.Password == password);
            return existUser == null ? throw new UserNotFoundException("User notfound") : true;
        }
    }
}
