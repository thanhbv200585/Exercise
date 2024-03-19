namespace Exercise15.Exceptions
{
    public class NotFoundSemesterException : Exception
    {
        public NotFoundSemesterException()
        {
        }

        public NotFoundSemesterException(string? message) : base(message)
        {
        }

        public NotFoundSemesterException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
