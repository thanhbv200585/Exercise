namespace Exercise13.Exceptions
{
    internal class PhoneException : Exception
    {
        public PhoneException() { }
        public PhoneException(string message) : base(message)
        {

        }

        public PhoneException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
