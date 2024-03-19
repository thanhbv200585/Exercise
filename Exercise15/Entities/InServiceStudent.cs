namespace Exercise15.Entities
{
    public class InServiceStudent : Student
    {
        public string TrainingPlace { get; set; }
        public InServiceStudent(string Name, DateTime DoB, int EntranceYear, int EntryScore, string TrainingPlace) : base(Name, DoB, EntranceYear, EntryScore)
        {
            this.TrainingPlace = TrainingPlace;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(string.Format("InServiceStudent{{Name = {0}, DoB = {1}, EntranceYear = {2}, EntryScore = {3}, TrainingPlace = {4}}}"
                , Name, DoB, EntranceYear, EntryScore, TrainingPlace));
        }
    }
}
