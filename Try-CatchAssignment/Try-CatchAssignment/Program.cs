using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_CatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Request age of user
            Console.WriteLine("Enter your age");
            string userAge = Console.ReadLine();

            //Convert input to an integer
            double parsedAge = double.Parse(userAge);

            //Display the year user was born
            DateTime currentTime = DateTime.Now;
            double birthDay = currentTime.Year - parsedAge;

            //Exeptions handled using Try/Catch
            if (parsedAge > 0)
            {
                try
                {
                    Console.WriteLine("You where born in {0}", birthDay);
                }
                catch
                {
                    Console.WriteLine("Please enter a real age.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
