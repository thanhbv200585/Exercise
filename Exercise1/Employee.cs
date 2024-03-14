namespace Exercise1
{
    internal class Employee
    {
        public string Name { get; }
        public int Age { get; }
        public string Sex { get; }
        public string Address { get; } 
        public Employee() { }

        public Employee(string name, int age, string sex, string address)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Address = address;
        }

        public override string ToString()
        {
            return string.Format("Employee {{Name = {0}, Age = {1}, Sex = {2}, Address = {3}}}", Name, Age,
                                 Sex, Address);
        }
    }
}
