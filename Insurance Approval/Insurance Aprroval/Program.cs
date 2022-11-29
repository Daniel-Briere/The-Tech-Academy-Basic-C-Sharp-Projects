using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Aprroval
{
    class Program
    {
        static void Main(string[] args)
        {
            //age question
            Console.WriteLine("What is your age?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool ageNum = number > 15;

            //dui question
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();

            //speeding ticket question
            Console.WriteLine("How many speeding tickets do you have?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool speedticketNum = number2 < 3;

            //qualified answer
            Console.WriteLine("Qualified?");
            if (ageNum && dui == "false" && speedticketNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
