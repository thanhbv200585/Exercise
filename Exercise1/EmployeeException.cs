namespace Exercise1
{
    internal class EmployeeException : Exception
    {
        public EmployeeException() { }
        public EmployeeException(string message) : base(message) { }
        public EmployeeException(string message, Exception inner) : base(message, inner) { }
    }
}
