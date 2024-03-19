using Exercise15.Services;

namespace Exercise15.Entities
{
    public class University(string UniversityName)
    {
        public const int FORMAL_STUDENT = 0;
        public const int IN_SERVICE_STUDENT = 1;
        public List<Department> Departments { get; } = new List<Department>();

        public string UniversityName { get; set; } = UniversityName;

        public void Run()
        {
            int choice = 0;
            while (choice != 11)
            {
                Menu();
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        string DepartmentName2 = InputService.InputString("Enter department name: ");
                        Department department2 = GetDepartment(DepartmentName2);
                        if (department2 == null)
                        {
                            Console.WriteLine("There is no department with name " + DepartmentName2);
                            break;
                        }
                        string StudentName2 = InputService.InputString("Enter student name: ");
                        Student student2 = department2.GetStudentByName(StudentName2);
                        if (student2 == null)
                        {
                            Console.WriteLine("There is no student " +  StudentName2);
                            break;
                        }
                        if (IsFormal(student2))
                        {
                            Console.WriteLine(student2.Name + " is a formal student");
                        }
                        else
                        {
                            Console.WriteLine(student2.Name + " is not a formal student");
                        }
                        break;
                    case 3:
                        string semester = InputService.InputString("Enter semester: ");
                        Console.WriteLine("Average score: " + GetAverageScore(semester));
                        break;
                    case 4:
                        string DepartmentName4 = InputService.InputString("Enter department name: ");
                        NoFormalStudentByDepartment(DepartmentName4);
                        break;
                    case 5:
                        string DepartmentName5 = InputService.InputString("Enter department name: ");
                        GetHighestEntryScoreStudentByDepartment(DepartmentName5);
                        break;
                    case 6:
                        string DepartmentName6 = InputService.InputString("Enter department name: ");
                        string TrainingPlace6 = InputService.InputString("Enter training place: ");
                        GetInServiceStudentByTrainingPlace(DepartmentName6, TrainingPlace6);
                        break;
                    case 7:
                        string DepartmentName7 = InputService.InputString("Enter department name: ");
                        ShowGoodStudentsLastSemester(DepartmentName7);
                        break;
                    case 8:
                        string DepartmentName8 = InputService.InputString("Enter department name: ");
                        GetHighestAverageStudent(DepartmentName8);
                        break;
                    case 9:
                        string DepartmentName9 = InputService.InputString("Enter department name: ");
                        ShowAllStudents(DepartmentName9);
                        break;
                    case 10:
                        string DepartmentName10 = InputService.InputString("Enter department name: ");
                        ShowNoStudentByYear(DepartmentName10);
                        break;
                    case 11:
                        Console.WriteLine("Exit!");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }

        private void Menu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Check formal student");
            Console.WriteLine("3. Calculate average score by semester");
            Console.WriteLine("4. Get total number of formal student");
            Console.WriteLine("5. Get students having the highest score by department");
            Console.WriteLine("6. Get the list of training place by department");
            Console.WriteLine("7. Get good students last semester by department");
            Console.WriteLine("8. Get student having highest score by department");
            Console.WriteLine("9. Sort");
            Console.WriteLine("10. Stat the number of student by year by department");
            Console.WriteLine("11. Exit");
            Console.WriteLine("=================================");
        }
        public void AddStudent()
        {
            string Departname = InputService.InputString("Enter department name: ");
            Department department = GetDepartment(Departname);
            if (department == null)
            {
                Console.WriteLine("Not found department");
                return;
            }

            Console.WriteLine("Formal student (0) or In-service Student (1): ");
            int choice = InputService.InputInt(">>");
            string Name = InputService.InputString("Enter name: ");
            DateTime DoB = InputService.InputDateTime("Enter DoB: ");
            int EntranceYear = InputService.InputInt("Enter entrance year: ");
            int EntryScore = InputService.InputInt("Enter entry score: ");

            switch (choice)
            {
                case FORMAL_STUDENT:
                    department.AddStudent(new FormalStudent(Name, DoB, EntranceYear, EntryScore));
                    break;
                case IN_SERVICE_STUDENT:
                    string TrainingPlace = InputService.InputString("Enter training place: ");
                    department.AddStudent(new InServiceStudent(Name, DoB, EntranceYear, EntryScore, TrainingPlace));
                    break;
                default:
                    break;
            }
        }

        private Department GetDepartment(string DepartmentName)
        {
            return Departments.Find(department => department.DepartmentName == DepartmentName);
        }

        public bool IsFormal(Student student)
        {
            return student.GetType() == typeof(FormalStudent);
        }

        public int NoFormalStudentByDepartment(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return -1;
            }
            int count = department.Students.FindAll(IsFormal).Count;
            Console.WriteLine("The number of formal students from department " + DepartmentName + ": " + count);
            return count;
        }

        public double GetAverageScore(string semester)
        {
            return Departments.Average(department => department.GetAverageScore(semester));
        }
        public Student GetHighestEntryScoreStudentByDepartment(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return null;
            }
            Student HighestStudent = department.Students.MaxBy(student => student.EntryScore);
            if (HighestStudent != null)
            {
                HighestStudent.ShowInfo();
            }
            else
            {
                Console.WriteLine("There is no student in department " + DepartmentName);
            }
            return HighestStudent;
        }

        public List<Student> GetInServiceStudentByTrainingPlace(string DepartmentName, string TrainingPlace)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return null;
            }
            return department.GetInServiceStudentByTrainingPlace(TrainingPlace);
        }

        public void ShowGoodStudentsLastSemester(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return;
            }
            department.GetGoodStudentsLastSemester();
        }

        public void GetHighestAverageStudent(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return;
            }
            department.GetHighestAverageStudent();
        }

        public void ShowAllStudents(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return;
            }
            department.ShowAllStudents();
        }

        public void ShowNoStudentByYear(string DepartmentName)
        {
            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return;
            }
            department.ShowNoStudentByYear();
        }

        public void InputSemesterResult(string DepartmentName, string StudentName)
        {
            //string DepartmentName = InputService.InputString("Enter department name: ");
            //string StudentName = InputService.InputString("Enter student name: ");

            Department department = GetDepartment(DepartmentName);
            if (department == null)
            {
                Console.WriteLine("There is no department with name " + DepartmentName);
                return;
            }
            Student student = department.GetStudentByName(StudentName);
            if (student == null)
            {
                Console.WriteLine("There is no student " + StudentName);
                return;
            }
            student.InputSemesterResult();
        }
    }

}
