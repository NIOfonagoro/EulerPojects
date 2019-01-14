using System.Collections.Generic;

namespace Eulers.EulerOne
{
    public class ListOfMultiples : List<int>
    {
        public ListOfMultiples(int multiple, int max)
        {
            for (int i = 1; i < max; i++)
            {
                if (i % multiple == 0)
                {
                    Add(i);
                }
            }
        }
    }
}
