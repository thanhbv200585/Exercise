using Exercise15.Services;

namespace Exercise15.Entities
{
    public class Student(string Name, DateTime DoB, int EntranceYear, int EntryScore) : IComparable<Student>
    {
        
        public string Name { get; set; } = Name;
        public DateTime DoB { get; set; } = DoB;
        public int EntranceYear { get; set; } = EntranceYear;
        public int EntryScore { get; set; } = EntryScore;
        public List<SemesterResult> SemesterResults { get; set; } = [];

        public int CompareTo(Student? other)
        {
            if (this.GetType() == other.GetType())
            {
                return EntranceYear.CompareTo(other.EntranceYear);
            }
            else if (this.GetType() == typeof(FormalStudent))
            {
                return 1;
            }
            else
            {
                return -1;
            }
            
        }

        public void InputSemesterResult()
        {
            string semester = InputService.InputString("Enter semester: ");
            double average;
            Console.WriteLine("Enter average score: ");
            double.TryParse(Console.ReadLine(), out average);
            SemesterResults.Add(new SemesterResult(semester, average));
        }
        public virtual void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }   
}
