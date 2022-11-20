using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program title message
            Console.WriteLine("Anonymous Income Comparison Program.");
            //Person 1 info
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            //Person 2 info
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            //Person 1 annual salary
            Console.WriteLine("Annual salary of person 1: ");
            int num1 = Convert.ToInt32(hourlyRate1);
            int num2 = Convert.ToInt32(hoursWorked1);
            int product = num1 * num2 * 52;
            Console.WriteLine(product);
            //Person 2 annual salary
            Console.WriteLine("Annual salary of person 2: ");
            int num3 = Convert.ToInt32(hourlyRate2);
            int num4 = Convert.ToInt32(hoursWorked2);
            int product2 = num3 * num4 * 52;
            Console.WriteLine(product2);
            //Salary comparison
            Console.WriteLine("Does person 1 make more money then person 2?");
            Console.ReadLine();
            Console.WriteLine(product >= product2);
            Console.ReadLine();
        }
    }
}
