using System.Runtime.Serialization;

namespace Exercise2
{
    internal class Magazine : Document
    {
        
        public int NumOfPublish {  get; }
        public Month MonthOfPublish { get; }
        
        public Magazine(int id, string publisher, int numOfCopies, int numOfPublish, Month monthOfPublish) : base(id, publisher, numOfCopies)
        {
            this.NumOfPublish = numOfPublish;
            this.MonthOfPublish = monthOfPublish;
        }

        public override string ToString()
        {
            return string.Format("Magazine {{Id = {0}, Publisher = {1}, NumOfCopies = {2}, NumOfPublish = {3}, MonthOfPublish = {4}}}",
                Id, Publisher, NumOfCopies, NumOfPublish, MonthOfPublish);
        }
    }
    public enum Month
    {
        JAN = 1,
        FEB = 2,
        MAR = 3,
        APR = 4,
        MAY = 5,
        JUN = 6,
        JUL = 7,
        AUG = 8,
        SEP = 9,
        OCT = 10,
        NOV = 11,
        DEC = 12
    }
}
