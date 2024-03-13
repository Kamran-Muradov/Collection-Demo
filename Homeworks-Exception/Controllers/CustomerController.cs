using Homeworks_Exception.Services;
using Homeworks_Exception.Services.Interfaces;

namespace Homeworks_Exception.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public void GetAll()
        {
            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine(item.FullName + "-" +item.Address + "-" +item.Age);
            }
        }

        public void GetById()
        {
            try
            {
                //int id = 4;
                var result = _customerService.GetById();
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void GetAllByAge()
        {
            int age = 21;

            foreach (var item in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }

        public void GetAllCountOfDatas()
        {
            Console.WriteLine(_customerService.GetCount());
        }

        public void OrderByAge()
        {
            string ordering = "desc";

            var response = _customerService.OrderByAge(ordering);

            foreach (var item in response)
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }
    }
}
