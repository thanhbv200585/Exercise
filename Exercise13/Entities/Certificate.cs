namespace Exercise13.Entities
{
    public class Certificate(int id, string name, string rank, DateTime date)
    {
        public int CertificateID { get; } = id; 
        public string CertificateName { get; } = name;
        public string CertificateRank { get; } = rank;
        public DateTime CertificateDate { get; } = date;
    }
}
