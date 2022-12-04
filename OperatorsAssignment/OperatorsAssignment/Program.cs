using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();//instantiating first employee
            employee1.Id = 1;
            employee1.FirstName = "Dan";
            employee1.LastName = "Briere";

            Employee employee2 = new Employee();//instantiating second employee
            employee2.Id = 2;
            employee2.FirstName = "Ryan";
            employee2.LastName = "Kunz";

            Console.WriteLine((employee1 == employee2).ToString());//comparing employee id with overloaded == operator
            Console.ReadLine();
        }
    }
}
