using System;
namespace _7._3Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("vardas, pavarde: ");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            string initials = GetInitials(firstName, lastName);
            Console.WriteLine(initials);

        }
        public static string GetInitials(string name, string surname)
        {
            return name.Substring(0, 1) + "." + surname.Substring(0, 1) + ".";
        }
    }
}