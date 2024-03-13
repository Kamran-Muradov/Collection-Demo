using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Exception.Helpers.Exceptions
{
    internal class CustomMathExceptopions :Exception
    {
        public CustomMathExceptopions(string text):base(text)
        {
                
        }
    }
}
