using Homeworks_Exception.Models;

namespace Homeworks_Exception.Services.Interfaces
{
    internal interface IUserService
    {
        User[] GetAll();
        User GetById(int id);
        void Delete(int id);


    }
}
