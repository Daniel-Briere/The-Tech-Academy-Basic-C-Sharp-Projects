using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "dan";
            string age = "26";
            string sex = "male";
            name = name.ToUpper();
            StringBuilder pg = new StringBuilder();

            pg.Append("My name is " + name);
            pg.Append(Environment.NewLine);
            pg.Append("I am " + age);
            pg.Append(Environment.NewLine);
            pg.Append("I am a " + sex);

            Console.WriteLine(pg);
            Console.ReadLine();
        }
    }
}
