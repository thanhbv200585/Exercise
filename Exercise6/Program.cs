using Exercise6;

public class Program
{
    public static void Main()
    {
        University university = new University("BK");
        university.AddClass(new Class("IT1"));
        university.AddClass(new Class("IT2"));
        university.AddClass(new Class("IT3"));

        Student student1 = new("Thanh1", 23, "DN");
        Student student2 = new("Thanh2", 20, "HY");
        Student student3 = new("Thanh3", 23, "HY");
        Student student4 = new("Thanh4", 20, "DN");
        Student student5 = new("Thanh5", 23, "DN");
        university.AddStudent(student1);
        university.AddStudent(student2);
        university.AddStudent(student3);
        university.AddStudent(student4);
        university.AddStudent(student5);
        //university.AddStudent(student1);
        university.DisplayAllStudent();
        university.GetAllStudentAt20();
        university.GetAllStudentsAt23AndHometownInDN();
    }
}