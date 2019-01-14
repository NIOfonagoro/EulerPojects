using System.Collections.Generic;
using System.Linq;

namespace Eulers.EulerOne
{
    public class UnionOfLists : List<int>
    {
        public UnionOfLists(List<int> MultiplesOne, List<int> MultiplesTwo)
        {
            var list = MultiplesOne.Union(MultiplesTwo).OrderBy(p => p);
            //for ordered list add .OrderBy(p=>p)
            foreach (var item in list)
            {
                Add(item);
            }
        }
    }
}