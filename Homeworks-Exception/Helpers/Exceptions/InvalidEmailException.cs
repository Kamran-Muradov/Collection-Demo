
namespace Homeworks_Exception.Helpers.Exceptions
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException(string msj) : base(msj) { }
    }
}
