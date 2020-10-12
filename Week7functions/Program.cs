using System;

namespace Week7functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            AgeCalculator();
        }
        public static void AgeCalculator()
        {
            int userBirth = Int32.Parse(Console.ReadLine());
            int AgeofBirth = 2020 - userBirth;
            Console.WriteLine($"you are {AgeofBirth} years old ");
        }


    }
}
