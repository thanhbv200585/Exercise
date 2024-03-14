namespace Exercise1
{
    internal class Staff : Employee
    {
        public string Job { get; }
        public Staff() { }

        public Staff(string name, int age, string sex, string address, string job) 
            : base(name, age, sex, address)
        {
            Job = job;
        }

        public override string ToString()
        {
            return string.Format("Staff {{Name = {0}, Age = {1}, Sex = {2}, Address = {3}, Job = {4}}}", Name, Age,
                                 Sex, Address, Job);
        }
    }
}
