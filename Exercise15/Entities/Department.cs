using Exercise15.Exceptions;

namespace Exercise15.Entities
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Student> Students { get; } = new List<Student>();
        public Department(string Name)
        {
            this.DepartmentName = Name;
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public List<Student> GetInServiceStudentByTrainingPlace(string TrainingPlace)
        {
            List<Student> FindingStudents = Students.FindAll(student => student.GetType() == typeof(InServiceStudent))
                .FindAll(student => ((InServiceStudent)student).TrainingPlace == TrainingPlace);
            if (FindingStudents.Count > 0)
            {
                FindingStudents.ForEach(student => student.ShowInfo());
            }
            else
            {
                Console.WriteLine("Cannot find training place " + TrainingPlace);
            }
            return FindingStudents;
        }

        public List<Student> GetGoodStudentsLastSemester()
        {
            List<Student> FindingStudents = Students.FindAll(student =>
            {
                try
                {
                    int lastSemester = student.SemesterResults.Count - 1;
                    if (lastSemester >= 0)
                    {
                        return student.SemesterResults[lastSemester].Average > 8;
                    }
                    else
                    {
                        throw new NotFoundSemesterException("There is no semester");
                    }
                }
                catch (NotFoundSemesterException e)
                {
                    Console.WriteLine(e.Message);
                }
                return false;
            });
            FindingStudents.ForEach(student => student.ShowInfo());
            return FindingStudents;
        }

        public Student GetHighestAverageStudent()
        {
            double average = Students.Max(student => student.SemesterResults.Max(result => result.Average));
            Student FindingStudent = Students.Find(student => student.SemesterResults.Max(result => result.Average) == average);
            if (FindingStudent != null)
            {
                FindingStudent.ShowInfo();
                return FindingStudent;
            }
            Console.WriteLine("Cannot find the highest student");
            return FindingStudent;
        }

        public void ShowNoStudentByYear()
        {
            var group = Students.GroupBy(student => student.EntranceYear);
            foreach (var item in group)
            {
                Console.WriteLine(item.Key + ": " + item.Count());
            }
        }

        public Student GetStudentByName(string Name)
        {
            return Students.Find(student => student.Name == Name);
        }

        public double GetAverageScore(string semester)
        {
            if (Students.Count <= 0)
            {
                Console.WriteLine("There is no student in Department: " + DepartmentName);
                return 0;
            }
            return Students.Average(student =>
            {
                SemesterResult? Finding = student.SemesterResults.Find(res => res.SemesterName == semester);
                try
                {
                    if (Finding == null)
                    {
                        throw new NotFoundSemesterException("Not found the semester " + semester);
                    }
                }
                catch (NotFoundSemesterException e)
                {
                    Console.WriteLine(e.Message);
                    return 0;
                }
                return Finding.Average;
            });
        }

        public void ShowAllStudents()
        {
            Students.ForEach(student => student.ShowInfo());
        }
    }
}
