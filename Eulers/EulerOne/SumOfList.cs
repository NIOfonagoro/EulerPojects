using System.Collections.Generic;
using System.Linq;

namespace Eulers.EulerOne
{
    internal class SumOfList
    {
        public int total { get; set; }

        public SumOfList(List<int> ListOfInts)
        {
            total = ListOfInts.Sum();
        }
    }
}