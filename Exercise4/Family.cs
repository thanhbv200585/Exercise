namespace Exercise4
{
    internal class Family
    {
        string name;
        List<Person> _people;
        public Family(string name)
        {
            _people = new List<Person>();
            this.name = name;
        }

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public void DisplayFamilyInfo()
        {
            _people.ForEach(person => Console.WriteLine(person.ToString()));
        }

        public override string ToString()
        {
            string result = "\n";
            foreach (Person person in _people)
            {
                result += person.ToString() + "\n";
            }
            return "Family{" + name + result + "}"; 
        }
    }
}
