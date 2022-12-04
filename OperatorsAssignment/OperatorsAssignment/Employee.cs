using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)//comparing employee IDs with ==
        {
            return employee1.Id == employee2.Id ? true : false;
        }

        public static bool operator!= (Employee employee1, Employee employee2)//comparing employee IDs with !=
        {
            return employee1.Id != employee2.Id ? true : false;
        }
    }
}
