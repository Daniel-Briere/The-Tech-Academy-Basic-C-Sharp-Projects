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
            Console.WriteLine("What is your age?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool ageNum = number > 15;

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool stNum = number2 < 3;

            Console.WriteLine("Qualified?");
            string result = ageNum & !dui & stNum ? "True" : "False";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
