using Homeworks_Exception.Data;
using Homeworks_Exception.Helpers.Enums;
using Homeworks_Exception.Models;
using Homeworks_Exception.Services.Interfaces;

namespace Homeworks_Exception.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id = null)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(string ordering)
        {
            switch (ordering)
            {
                case nameof(OrderType.asc):
                    return AppDbContext.customers.OrderBy(m => m.Age).ToList();
                case nameof(OrderType.desc):
                    return AppDbContext.customers.OrderByDescending(m => m.Age).ToList();
            }

            return AppDbContext.customers;
        }

        public List<Customer> Search(Predicate<Customer> predicate)
        {
            List<Customer> result = new List<Customer>();

            foreach (var item in AppDbContext.customers)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            
            return result;
        }
    }
}
