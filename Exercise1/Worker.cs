namespace Exercise1
{
    internal class Worker : Employee
    {
        public int Level { get; }
        public Worker() { }

        public Worker(string name, int age, string sex, string address, int level) 
            : base(name, age, sex, address)
        {
            Level = level;
        }

        public override string ToString()
        {
            return string.Format("Worker {{Name = {0}, Age = {1}, Sex = {2}, Address = {3}, Level = {4}}}", Name, Age,
                                 Sex, Address, Level);
        }
    }
}
