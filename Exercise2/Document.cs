namespace Exercise2
{
    public class Document
    {
        public int Id { get; }
        public string Publisher { get; }
        public int NumOfCopies { get; }

        public Document(int id, string publisher , int numOfCopies)
        {
            Id = id;
            Publisher = publisher;
            NumOfCopies = numOfCopies;
        }

        public override string ToString()
        {
            return string.Format("Document {{Id = {0}, Publisher = {1}, NumOfCopies = {2}}}", Id, Publisher, NumOfCopies);
        }
    }
}
