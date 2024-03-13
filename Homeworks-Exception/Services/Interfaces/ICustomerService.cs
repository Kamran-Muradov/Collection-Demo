using Homeworks_Exception.Models;

namespace Homeworks_Exception.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id = null);
        List<Customer> GetAllByAge(int age);
        int GetCount();
        List<Customer> OrderByAge(string ordering);
        List<Customer> Search(Predicate<Customer> predicate);

    }
}
