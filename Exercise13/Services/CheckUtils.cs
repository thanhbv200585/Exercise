using Exercise13.Exceptions;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Exercise13.Services
{
    internal class CheckUtils
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
                Console.WriteLine("Invalid Input!");
                throw new BirthDayException("Wrong format");
            }
            return res;
        }


        private static bool MailCheck(string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static string InputPhone()
        {
            Console.WriteLine("Enter phone: ");
            string phone;
            while((phone = Console.ReadLine()) != null)
            {
                try
                {
                    if (PhoneCheck(phone))
                    {
                        return phone;
                    }
                    else
                    {
                        throw new PhoneException("Phone Invalidation!");
                    }
                }
                catch (PhoneException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter phone: ");
                }
            }
            return phone;
        }

        public static string InputMail()
        {
            Console.WriteLine("Enter mail: ");
            string mail;
            while ((mail = Console.ReadLine()) != null)
            {
                try
                {
                    if (MailCheck(mail))
                    {
                        return mail;
                    }
                    else
                    {
                        throw new PhoneException("Mail Invalidation!");
                    }
                }
                catch (PhoneException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter mail: ");
                }
            }
            return mail;
        }

        private static bool PhoneCheck(string phone)
        {
            string pattern = @"^0[1-9]\d{8}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phone);
        }
    }
}
