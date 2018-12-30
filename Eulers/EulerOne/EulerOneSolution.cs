using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.EulerOne
{
    class EulerOneSolution
    {
        public EulerOneSolution()
        {
            ListOfMultiples MultiplesOfThree = new ListOfMultiples(3, 1000);
            ListOfMultiples MultiplesOfFive = new ListOfMultiples(5, 1000);

            UnionOfLists MultiplesOfThreeOrFive = new UnionOfLists(MultiplesOfThree, MultiplesOfFive);

            SumOfList ListSum = new SumOfList(MultiplesOfThreeOrFive);

            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine("Answer: " + ListSum.total);
            Console.WriteLine("");
        }
    }
}
