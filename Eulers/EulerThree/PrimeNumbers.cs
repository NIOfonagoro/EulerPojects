using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.EulerThree
{
    class PrimeNumbers : List<int>
    {
        public int MainNumber { get; set; }
        public int MaxFactor { get; set; }

        public List<int> Factors = new List<int>();

        public PrimeNumbers(int question)
        {
            MainNumber = question;
            FindFactors();
            Factors.ForEach(item => Console.WriteLine(item));
            FindPrimeFactors(Factors);
            ForEach(item => Console.WriteLine(item));
        }

        public int MaxDivisible(int _mainNumber)
        {
            MainNumber = _mainNumber;
            MaxFactor = (int)Math.Floor(Math.Sqrt(MainNumber));
            return MaxFactor;
        }

        public void FindFactors()
        {
            int max = MaxDivisible(MainNumber);
            int j;

            for (int i = 1; i < MaxFactor; i++)
            {
                if(MainNumber % i == 0)
                {
                    Factors.Add(i);
                    Factors.Add(MainNumber / i);
                }
            }
        }

        public void FindPrimeFactors(List<int> factors)
        {
            bool prime = true;

            foreach (var item in Factors)
            {
                if (item < 2)
                {
                    prime = false;
                    continue;
                }

                for (int i = 2; i < (int)Math.Floor(Math.Sqrt(MainNumber)) - 1; i++)
                {
                    if (item % i == 0)
                    {
                        prime = false;
                        continue;
                    }
                }

                if (prime == true)
                {
                    Add(item);
                }

            }
        }
    }
}
