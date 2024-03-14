namespace Exercise3
{
    public record Subject (string name);

    public class Contestant
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; }
        public int Priority { get; }
        public string SubjectGroupName { get; }
        Subject[] Subjects { get; }

        public Contestant(int id, string name, string address, int priority, string subjectGroupName) 
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Priority = priority;
            this.SubjectGroupName = subjectGroupName;
            this.Subjects = SubjectGroup(subjectGroupName);
        }

        private Subject[] SubjectGroup(string subjectGroupName)
        {
            switch (subjectGroupName) 
            {
                case "A":
                    return [new Subject("Math"), new Subject("Physics"), new Subject("Chemistry")];  // collection expression
                case "B":
                    return [new Subject("Math"), new Subject("Chemistry"), new Subject("Biology")];  
                case "C":
                    return [new Subject("Literature"), new Subject("History"), new Subject("Chemistry")];
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            return string.Format("Contestant{{id = {0}, name = {1}, address = {2}, priority = {3}, subjectGroupName = {4}}}"
                , Id, Name, Address, Priority, SubjectGroupName);
        }
    }
}
