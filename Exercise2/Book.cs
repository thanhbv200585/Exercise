namespace Exercise2
{
    internal class Book : Document
    {
        public string Author { get; }
        public int NumOfPages { get; }
        public Book(int id, string publisher, int numOfCopies, string author, int numOfPages ) : base(id, publisher, numOfCopies)
        {
            this.Author = author;
            this.NumOfPages = numOfPages;
        }

        public override string ToString()
        {
            return string.Format("Book {{Id = {0}, Publisher = {1}, NumOfCopies = {2}, Author = {3}, NumOfPages = {4}}}",
                Id, Publisher, NumOfCopies, Author, NumOfPages);
        }
    }
}
