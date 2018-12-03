using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.EulerTwo
{
    class AddNumbers
    {

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int FibonacciAdd(FibonacciSequence list)
        {
           return (list[list.Count - 1] + list[list.Count() - 2]);
        }

    }
}
