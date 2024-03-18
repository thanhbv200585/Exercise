namespace Exercise13.Entities
{
    public class Intern(int id, string fullname, DateTime birthDay, string phone, string email, int employee_type, string major, string semester, string universityName) : Employee(id, fullname, birthDay, phone, email, employee_type)
    {
        public string Major { get; set; } = major;
        public string Semester { get; set; } = semester;
        public string UniversityName { get; set; } = universityName;

        public override void ShowInfo()
        {
            Console.WriteLine("Intern {{ID = {0}, Fullname = {1}, BirthDay = {2}, Phone = {3}, Email = {4}, Employee_type = {5}, Major = {6}, Semester = {7}, UniversityName = {8}}}",
               ID, Fullname, BirthDay, Phone, Email, EmployeeType, Major, Semester, UniversityName);
        }
    }
}
