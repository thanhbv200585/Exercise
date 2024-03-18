namespace Exercise13.Entities
{
    public abstract class Employee
    {
        public static int Employee_count = 0;
        public int ID { get; }
        public string Fullname { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public EmployeeTypes EmployeeType { get; set; }
        public List<Certificate> Certificates { get; set; }

        public Employee(int ID, string fullname, DateTime birthDay, string phone, string email, int employee_type)
        {
            this.ID = ID;
            Fullname = fullname;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            EmployeeType = (EmployeeTypes)employee_type;
        }

        public abstract void ShowInfo();
    }

    public enum EmployeeTypes
    {
        Experience = 0,
        Fresher = 1,
        Intern = 2
    }
}
