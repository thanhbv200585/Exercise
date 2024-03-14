namespace Exercise6
{
    internal class Class
    {
        public string Name { get; }
        public List<Student> students { get; }
        public Class(string name) 
        {
            students = new List<Student>();
            this.Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
