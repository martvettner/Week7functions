using System;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctans = false;
            while (!correctans)
            {
                Console.WriteLine("What gender are you? write m or f");

                string userGender = Console.ReadLine().ToLower();
                if (userGender == "m")
                {
                    Console.WriteLine("Hello sir");
                    correctans = true;
                }
                else if (userGender == "f")
                {
                    Console.WriteLine("Hello madam ");
                    correctans = true;
                }
                else
                {
                    Console.WriteLine("Please enter m or f");
                }
            }
        }
    }
}
