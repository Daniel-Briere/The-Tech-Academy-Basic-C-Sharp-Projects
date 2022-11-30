using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string line = Console.ReadLine();
            Data = Int32.Parse(line);
            var operatorObject = new Operator();
            var result = operatorObject.GetAdd(Data);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
