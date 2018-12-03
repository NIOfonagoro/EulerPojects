using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Eulers.EulerTwo
{
    class FibonacciSequence : List<int>
    {
        int first = 0;
        int second = 1;
        int max { get; set; }


        

        public FibonacciSequence(int _max)
        {
            max = _max;

            Add(first + second);
            Add(second + this.First());

            while (this[this.Count - 1] < max)
            {
                Add(FibonacciAdd(this));
            }
  
            //Console.WriteLine(this.Count());
            ForEach(item => Console.WriteLine(item));
        }

        public int FibonacciAdd(FibonacciSequence list)
        {
            return (list[list.Count - 1] + list[list.Count() - 2]);
        }


    }
}
