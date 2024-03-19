using Exercise15.Exceptions;

namespace Exercise15.Services
{
    public class InputService
    {
        public static int InputInt(string prompt)
        {
            Console.WriteLine(prompt);
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Invalid Input. Please input again!");
                Console.WriteLine(prompt);
            }
            return res;
        }

        public static string InputString(string prompt)
        {
            Console.WriteLine(prompt);
            string res;
            while ((res = Console.ReadLine()) == null)
            {
                Console.WriteLine("Invalid Input. Please input again!");
                Console.WriteLine(prompt);
            }
            return res;
        }

        public static DateTime InputDateTime(string prompt)
        {
            Console.WriteLine(prompt);
            DateTime res;
            while (!DateTime.TryParse(Console.ReadLine(), out res))
            {
                try
                {
                    throw new BirthDayException("Invalid input string");
                }
                catch (BirthDayException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            try
            {
                if (res > DateTime.Now)
                {
                    throw new BirthDayException("The birthday must be before now");
                }
            }
            catch (BirthDayException e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }
}
