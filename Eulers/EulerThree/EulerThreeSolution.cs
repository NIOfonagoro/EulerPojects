using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.EulerThree
{
    class EulerThreeSolution
    {
        public EulerThreeSolution()
        {
            Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29.");
            Console.WriteLine("What is the largest prime factor of the number 600851475143 ?");

            //Round down Square root of question. For loop cycling through incremental steps seeing if divisible with no remainder. Add to list if so.
            PrimeNumbers Solution = new PrimeNumbers(1000);
            //Console.WriteLine(Solution.Max());
            Console.WriteLine("");


        }

        
    }
}
