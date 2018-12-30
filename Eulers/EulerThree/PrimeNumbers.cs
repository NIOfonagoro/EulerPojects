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


        public PrimeNumbers(int question)
        {
            MainNumber = question;
            Factors();
            ForEach(item => Console.WriteLine(item));
        }

        public int MaxDivisible(int _mainNumber)
        {
            MainNumber = _mainNumber;
            MaxFactor = (int)Math.Floor(Math.Sqrt(MainNumber));
            return MaxFactor;
        }

        public void Factors()
        {
            int max = MaxDivisible(MainNumber);
            int j;

            for (int i = 1; i < MaxFactor; i++)
            {
                if(MainNumber % i == 0)
                {
                    Add(i);
                    Add(MainNumber / i);
                }
            }

        }
    }
}
