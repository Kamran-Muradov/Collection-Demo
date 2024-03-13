//Ededin faktorilalini tapan method yazmaq. Eger menfi eded
//    daxil edilibse custom exception cixarsin.

using Homeworks_Exception.Controllers;
using Homeworks_Exception.Data;
using Homeworks_Exception.Models;
using Homeworks_Exception.Services;

//CalculationController calculation = new();
//calculation.GetFactorial();

//AccountController accountController = new();

//accountController.SignIn();



CustomerController customerController = new();

//customerController.GetAll();

//customerController.GetById();

//customerController.GetAllByAge();

//customerController.GetAllCountOfDatas();

//customerController.OrderByAge();

CustomerService customerService = new();

List<Customer> customers = customerService.Search(m => m.FullName.Contains("E"));

foreach (var item in customers)
{
    Console.WriteLine(item.FullName);
}
