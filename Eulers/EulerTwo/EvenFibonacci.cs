using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.EulerTwo
{
    class EvenFibonacci : List<int>
    {
        public int _number { get; set; }

        public EvenFibonacci(List<int> list)
        {
            foreach (int number in list)
            {
                _number = number;

                if(_number % 2 == 0)
                {
                    Add(number);                    
                }
            }
        }

        public void SumOfList(List<int> list)
        {
            int Sum = list.Sum();
            Console.WriteLine(Sum);
           
        }
    }
}
