using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Constant Variable
            const string programName = "Constructor Assignment";

            Console.WriteLine("This is my constant variable for the {0}", programName);
            Console.ReadLine();
            //variable using "var"
            Console.WriteLine("Please enter anything");
            var anyThing = Console.ReadLine();
            Console.WriteLine("You wrote" + anyThing);
            Console.ReadLine();
        }
            //Chained constructors
            class Foo
        {
            private int id;
            private string name;

            public Foo() : this(0, "")
            {
            }

            public Foo(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public Foo(int id) : this(id, "")
            {
            }

            public Foo(string name) : this(0, name)
            {
            }
        }
    }
}
