using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            string userInput = Console.ReadLine();
            // int userAge = CalculateAge(userInput);

            //Console.WriteLine($"you are {userAge} years old");

            //ValidateAge(userAge);
            ValidateAge(CalculateAge(userInput));
        }

        public static int CalculateAge(string userInput)
        {
            int userAge = 2020 - Int32.Parse(userInput);
            return userAge;
        }

        public static void ValidateAge(int age)
        {
            if(age < 18 )
            {
                Console.WriteLine("you are not old enough ");
            }
            else
            {
                Console.WriteLine("GO GET IT!");
            }
        }

    }
}
