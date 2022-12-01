using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string line = Console.ReadLine();
            var operatorObject = new Operator();

            if (int.TryParse(line, out int Num))
            {
                Console.WriteLine(operatorObject.GetAdd(Num));
            }
            else if (decimal.TryParse(line, out decimal Dec))
            {
                Console.WriteLine(operatorObject.GetAdd(Dec));
            }
            else if (operatorObject.GetAdd(line, out int stgNum))
            {
                Console.WriteLine(stgNum);
            }
            else
            {
                Console.WriteLine("Invalid Input!!!");
            }

            Console.ReadLine();

        }
    }
}
