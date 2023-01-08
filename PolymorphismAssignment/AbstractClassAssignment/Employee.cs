using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
