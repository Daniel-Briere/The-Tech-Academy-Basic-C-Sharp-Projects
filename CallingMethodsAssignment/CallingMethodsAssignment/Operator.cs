using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Operator
    {
        public double GetAdd(int data)
        {
            data = data + 4;
            return GetSubtract(data);
        }

        public double GetSubtract(double data)
        {
            data = data - 3;
            return GetDivide(data);
        }

        public double GetDivide(double data)
        {
            return data / 3;
        }
    }
}
