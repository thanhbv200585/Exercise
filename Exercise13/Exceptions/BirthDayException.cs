namespace Exercise13.Exceptions
{
    internal class BirthDayException : Exception
    {
        public BirthDayException() { }
        public BirthDayException(string message) : base(message)
        {

        }

        public BirthDayException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
