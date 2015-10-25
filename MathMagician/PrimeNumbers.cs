using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 1;
            // don't think this is applicable increment = 0;
        }

        public override int GetNext(int x)
        {
            List<int> primes = new List<int> { };
            for (int i = x; primes.Count < 2; i++)
            {
                List<int> Test = new List<int> { };
                for (int n = 1; n <= i; n++)
                {
                    if (i % n == 0)
                    {
                        Test.Add(i);
                    }
                    if (i == n && Test.Count < 3)
                    {
                        primes.Add(i);
                    }
                }
            }
            return primes[1];
        }
    }
}
