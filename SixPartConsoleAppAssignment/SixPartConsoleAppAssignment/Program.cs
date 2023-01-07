using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[]{ "Shaggy", "Scooby", "Valma", "Daphne", "Fred" };

            Console.WriteLine("Please enter anything.");
            string userInput = Console.ReadLine();

            for (int i = 0; i < Names.Length; i++)
            {
                Names[i] = Names[i] + userInput;
            }


            //fixed loop with a for statment
            for (int i = 0; i <= Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadLine();
        }
    }
}
