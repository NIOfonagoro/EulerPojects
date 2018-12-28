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

        

        public FibonacciSequence()
        {
            

            Add(first + second);
            Add(second + this.First());      
            
        }

        public void CreateSequence(int _max)
        {
            max = _max;

            while (this[this.Count - 1] < max)
            {
                Add(FibonacciAdd(this));
            }

            Remove(this.Last());

            //Console.WriteLine(this.Count());

            //ForEach(item => Console.WriteLine(item));
        }


        public int FibonacciAdd(FibonacciSequence list)
        {
            return (list[list.Count - 1] + list[list.Count() - 2]);
        }
        

    }
}
