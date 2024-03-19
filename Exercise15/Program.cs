using Exercise15.Entities;

public class Program()
{
    public static void Main()
    {
        University HUST = new University("HUST");
        HUST.Departments.Add(new Department("SoICT"));
        HUST.Departments.Add(new Department("SEEE"));
        HUST.Departments.Add(new Department("SEM"));
        
        HUST.Run();
    }
}