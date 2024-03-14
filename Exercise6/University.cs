using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class University
    {
        string name;
        List<Class> classes;
        public University(string name)
        {
            classes = new List<Class>();
            this.name = name;
        }

        public void AddClass(Class c)
        {
            classes.Add(c);
        }
        public void AddStudent(Student student)
        {
            Console.WriteLine("Which class does the student belong to?");
            string name = Console.ReadLine();
            Class _class = classes.Find(_class => _class.Name == name);

            if (_class == null)
            {
                Console.WriteLine("Class {0} doesn't exist!!", name);
            }
            else
            {
                _class.AddStudent(student);
                Console.WriteLine("Student {0} is added successfully to class {1}", student.Name, _class.Name);
            }
        }

        
        public void DisplayAllStudent()
        {
            Console.WriteLine("==============================================");
            foreach (Class _class in classes)
            {
                Console.WriteLine("List of student in class " + _class.Name);
                foreach (Student student in _class.students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            Console.WriteLine("==============================================");
        }

        public void GetAllStudentAt20()
        {
            Filter(student => student.Age == 20, "All students at 20");
        }

        public void GetAllStudentsAt23AndHometownInDN()
        {
            Console.WriteLine("The total number of students that is at 23 and whose hometown is DN: " +
                 Filter(student => student.Age == 23 && student.Hometown == "DN"));
        }

        private void Filter(Predicate<Student> predicate, string filterName)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine(filterName);
            foreach (Class _class in classes)
            {
                Console.WriteLine("List of students in class " + _class.Name);
                foreach (Student student in _class.students)
                {
                    if (predicate.Invoke(student))
                    {
                        Console.WriteLine(student.ToString());
                    }
                }
            }
            Console.WriteLine("==============================================");
        }

        private int Filter(Predicate<Student> predicate)
        {
            int count = 0;
            foreach (Class _class in classes)
            {
                foreach (Student student in _class.students)
                {
                    if (predicate.Invoke(student))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
