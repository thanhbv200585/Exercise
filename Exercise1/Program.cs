using Exercise1;

public class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager();
        manager.AddEmployee(new Worker("John Doe", 40, "Male", "123 Main St.", 10));
        manager.AddEmployee(new Worker("Jane Smith", 25, "Female", "456 Elm St.", 1));
        manager.AddEmployee(new Worker("Alice Jones", 32, "Female", "789 Oak St.", 5));

        manager.AddEmployee(new Staff("John Doe", 40, "Male", "123 Main St.", "Manager"));
        manager.AddEmployee(new Staff("Jane Smith", 25, "Female", "456 Elm St.", "Receptionist"));

        manager.DisplayEmployee();
        Console.WriteLine("-------------------------------------------");
        List<Employee> employees = manager.SearchByName("John Doe");
        employees.ForEach(e => { 
            Console.WriteLine(e.ToString()); 
        });
    }
}