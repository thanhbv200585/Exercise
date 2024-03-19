namespace Exercise15.Exceptions
{
    public class BirthDayException : Exception
    {
        public BirthDayException()
        {
        }

        public BirthDayException(string? message) : base(message)
        {
        }

        public BirthDayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
