using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number
            Console.WriteLine("Enter a number");
            string numLog = Console.ReadLine();

            //Logs the number to a new text file
            File.WriteAllText(@"C:\users\nwh15\Logs\log_2.txt", numLog);

            //Prints the file back to the user
            Console.WriteLine(File.ReadAllText(@"C:\users\nwh15\Logs\log_2.txt"));
            Console.ReadLine();

        }
    }
}
