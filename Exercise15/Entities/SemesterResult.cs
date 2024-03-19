namespace Exercise15.Entities
{
    public class SemesterResult(string SemesterName, double Average)
    {
        public string SemesterName { get; set; } = SemesterName;
        public double Average { get; set; } = Average;
    }
}
