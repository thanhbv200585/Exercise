namespace Exercise13.Entities
{
    public class Experience(int id, string fullname, DateTime birthDay, string phone, string email, int employee_type, int expInYear, string proSkill) : Employee(id, fullname, birthDay, phone, email, employee_type)
    {
        public int ExpInYear { get; set; } = expInYear;
        public string ProSkill { get; set; } = proSkill;

        public override void ShowInfo()
        {
            Console.WriteLine("Experience {{ID = {0}, Fullname = {1}, BirthDay = {2}, Phone = {3}, Email = {4}, Employee_type = {5}, ExpInYear = {6}, Proskill = {7}}}",
               ID, Fullname, BirthDay, Phone, Email, EmployeeType, ExpInYear, ProSkill);
        }
    }
}
