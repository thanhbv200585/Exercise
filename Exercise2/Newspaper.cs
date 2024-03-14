namespace Exercise2
{
    internal class Newspapers : Document
    {
        public const string DateTimeFormat = "yyyy/MM/dd";
        public DateTime DateOfPublish { get; }

        public Newspapers(int id, string publisher, int numOfCopies, DateTime dateOfPublish) : base(id, publisher, numOfCopies)
        {
            this.DateOfPublish = dateOfPublish;
        }

        public override string ToString()
        {
            Convert.ToDateTime("2024/02/23");
            return string.Format("Newspapers {{Id = {0}, Publisher = {1}, NumOfCopies = {2}, DateOfPublish = {3}}}",
                Id, Publisher, NumOfCopies, DateOfPublish);
        }
    }
}
