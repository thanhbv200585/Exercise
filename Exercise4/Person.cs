using System;

namespace Exercise4
{
    public class Person(string name, int age, string job, string id)
    {
        public override string ToString()
        {
            return string.Format("Person{{Name = {0}, Age = {1}, Job = {2}, ID = {3}}}",
                name, age, job, id);
        }
    }
}
