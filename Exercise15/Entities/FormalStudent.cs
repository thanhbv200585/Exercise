namespace Exercise15.Entities
{
    public class FormalStudent : Student
    {
        public FormalStudent(string Name, DateTime DoB, int EntranceYear, int EntryScore) : base(Name, DoB, EntranceYear, EntryScore)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine(string.Format("FormalStudent{{Name = {0}, DoB = {1}, EntranceYear = {2}, EntryScore = {3}}}"
                , Name, DoB, EntranceYear, EntryScore));
        }
    }
}
