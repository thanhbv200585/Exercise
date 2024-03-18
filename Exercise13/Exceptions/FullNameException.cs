namespace Exercise13.Exceptions
{
    internal class FullNameException : Exception
    {
        public FullNameException() { }
        public FullNameException(string message) : base(message)
        {

        }

        public FullNameException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
