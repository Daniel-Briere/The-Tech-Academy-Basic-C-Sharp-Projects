using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a emplyee object
            Employee employee = new Employee();
            //assigning emplyee name
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //call sayname() method
            employee.SayName();
            Console.ReadLine();
            IQuittable IQuittable = new Employee();
            IQuittable.Quit();
            Console.ReadLine();
        }
    }
}
