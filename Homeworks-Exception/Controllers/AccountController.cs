using Homeworks_Exception.Helpers.Constants;
using Homeworks_Exception.Helpers.Exceptions;
using Homeworks_Exception.Services;
using Homeworks_Exception.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void SignIn()
        {
            string email = "fatimacode.edu.az";
            string password = "fatime5123";

            try
            {
                if (!email.Contains('@'))
                {
                    throw new InvalidEmailException(ResponseMessages.EmailFormat);
                }

                bool response = _accountService.SingIn(email, password);

                if (response)
                    Console.WriteLine("Sign in success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
