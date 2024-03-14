namespace Exercise1
{
    internal class EmployeeManager
    {
        public List<Employee> Employees {  get; }
        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public EmployeeManager(List<Employee> employees) 
        { 
            Employees = employees;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new EmployeeException("Added employee is null!");
            }
            Employees.Add(employee);
        }

        public List<Employee> SearchByName(string name)
        {
            return this.Employees.FindAll(e => e.Name.Equals(name));
        }

        public void DisplayEmployee()
        {
            this.Employees.ForEach(e => {
                Console.WriteLine(e.ToString());
            });
        }
    }
}
