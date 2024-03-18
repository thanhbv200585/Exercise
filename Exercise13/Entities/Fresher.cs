namespace Exercise13.Entities
{
    public class Fresher(int id, string fullname, DateTime birthDay, string phone, string email, int employee_type, DateTime graduationDate, string graduationRank, string education) : Employee(id, fullname, birthDay, phone, email, employee_type)
    {
        public DateTime GraduationDate { get; set; } = graduationDate;
        public string GraduationRank { get; set; } = graduationRank;
        public string Education { get; set; } = education;

        public override void ShowInfo()
        {
            Console.WriteLine("Fresher {{ID = {0}, Fullname = {1}, BirthDay = {2}, Phone = {3}, Email = {4}, Employee_type = {5}, GraduationDate = {6}, GraduationRank = {7}, Education = {8}}}",
               ID, Fullname, BirthDay, Phone, Email, EmployeeType, GraduationDate, GraduationRank, Education);
        }
    }
}
