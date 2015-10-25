using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    public class FibNumbers : NaturalNumbers
    {
        public FibNumbers()
        {
            first = 1;
            increment = 0;
        }

        public override int GetNext(int num)
        {
            int nextFib = increment + num;
            increment = num;
            return nextFib;
        }
    }
}