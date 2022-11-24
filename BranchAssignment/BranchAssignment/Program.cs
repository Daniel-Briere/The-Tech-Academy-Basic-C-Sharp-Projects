using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro message
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            Console.ReadLine();
            //Weight request message
            Console.WriteLine("Please enter the package weight.");
            int pakWght = Convert.ToInt32(Console.ReadLine());

            string weight = pakWght <= 50 ? "Please enter package the width." : "Package too heavy to be shipped via Package Express. Have a good day.";

            Console.WriteLine(weight);
            //Width request message
            int pakWdth = Convert.ToInt32(Console.ReadLine());

            string width = pakWdth <= 50 ? "Please enter package the height." : "Package too wide to be shipped via Package Express. Have a good day.";

            Console.WriteLine(width);
            //Height request message
            int pakHgth = Convert.ToInt32(Console.ReadLine());

            string height = pakHgth <= 50 ? "Please enter package the length." : "Package too wide to be shipped via Package Express. Have a good day.";

            Console.WriteLine(height);
            //Length request message
            int pakLgth = Convert.ToInt32(Console.ReadLine());

            string length = pakLgth <= 50 ? "Your estimated total for shipping this package is: $" : "Package too wide to be shipped via Package Express. Have a good day.";
            //Total calulations
            int total = (pakWdth * pakHgth * pakWdth) * pakWght / 100;

            Console.WriteLine(length + total);
            Console.WriteLine("Thank you!");
            Console.ReadLine();


        }
    }
}
