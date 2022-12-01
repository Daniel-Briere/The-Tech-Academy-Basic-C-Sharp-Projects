using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Operator
    {
        public int GetAdd(int data)
        {
            return data + 4;
        }

        public int GetAdd (decimal data)
        {
            int intNum = Convert.ToInt32(data);
            return intNum - 6;
        }

        public bool GetAdd(string data, out int stgNum)
        {
            if (int.TryParse(data, out int intNum))
            {
                stgNum = intNum * 4;
                return true;
            }
            else
            {
                stgNum = 0;
                return false;
            }
        }
    }
}
