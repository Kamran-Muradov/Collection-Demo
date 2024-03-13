using Homeworks_Exception.Models;
using Homeworks_Exception.Services.Interfaces;

namespace Homeworks_Exception.Services
{
    internal class UserService : IUserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new() {
                    Id = 1,
                    FullName="Fatime Qayxanova",
                    Email = "fatima@code.edu.az",
                    Password = "fatime123"
                },
                new() {
                    Id = 2,
                    FullName="Fexriyye Tagizade",
                    Email = "fexriyye@code.edu.az",
                    Password = "fexriyye123"
                },
                new() {
                    Id = 3,
                    FullName="Afide Veliyeva",
                    Email = "afide@code.edu.az",
                    Password = "afide123"
                },
            };
        }




        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
