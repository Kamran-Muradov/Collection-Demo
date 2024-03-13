using Homeworks_Exception.Helpers.Exceptions;
using Homeworks_Exception.Helpers.Extensions;

namespace Homeworks_Exception.Controllers
{
    internal class CalculationController
    {
        public void GetFactorial()
        {
            try
            {
                int number = -5;
                Console.WriteLine(number.FactorialOfNumber());
            }
            catch (CustomMathExceptopions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
