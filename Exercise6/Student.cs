namespace Exercise6
{
    public class Student(string name, int age, string hometown)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;
        public string Hometown { get; } = hometown;
        public override string ToString()
        {
            return string.Format("Student{{Name = {0}, Age = {1}, Hometown = {2}}}", name, age, hometown);
        }
    }
}
