namespace Exercise4
{
    internal class Street
    {
        string name;
        List<Family> _families;

        public Street(string name)
        {
            _families = new List<Family>();
            this.name = name;
        }

        public void AddFamily(Family family)
        {
            _families.Add(family);
        }

        public void DisplayInfo()
        {
            _families.ForEach(family => Console.WriteLine(family.ToString()));
        }

        public void EnterFamilies()
        {
            int numOfFamily;
            Console.Write("How many families do you want to enter: n = ");
            int.TryParse(Console.ReadLine(), out numOfFamily);
            string familyName;
            for (int i = 0; i < numOfFamily; i++)
            {
                Console.WriteLine("Family name: ");
                familyName = Console.ReadLine();
                _families.Add(EnterFamily(familyName));
            }
        }
        private Family EnterFamily(string familyName)
        {
            int numOfPeople;
            int.TryParse(Console.ReadLine(), out numOfPeople);
            Family family = new Family(familyName);
            for (int i = 0; i < numOfPeople; i++)
            {
                family.AddPerson(EnterPerson());
            }
            return family;
        }

        private Person EnterPerson()
        {
            string name, job, ID;
            int age;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            int.TryParse(Console.ReadLine(), out age);
            Console.Write("Enter job: ");
            job = Console.ReadLine();
            Console.Write("Enter ID: ");
            ID = Console.ReadLine();
            return new Person(name, age, job, ID);  
        }
    }
}
