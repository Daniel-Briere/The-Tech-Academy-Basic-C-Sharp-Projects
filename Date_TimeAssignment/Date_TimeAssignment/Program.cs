using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_TimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print current time to console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            //Request number from user
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            //Convert the input to an integer
            double parsedInput = double.Parse(input);

            //Add X to current time, X being the number the user entered
            DateTime newTime = currentTime.AddHours(parsedInput);

            //Print the result to the console
            Console.WriteLine(newTime);
            Console.ReadLine();
        }
    }
}
