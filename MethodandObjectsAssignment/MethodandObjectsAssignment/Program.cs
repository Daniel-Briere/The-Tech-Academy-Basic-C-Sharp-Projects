using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create a emplyee object
            Employee employee = new Employee();
            //Assigning employee name
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // call superclass method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
