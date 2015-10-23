using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MathMagician
{
    public class NaturalNumbers
    {
        protected int first;

        public NaturalNumbers()
        {
            first = 1;
        }

        public int GetFirst()
        {
            return first;
        }
        public virtual int GetNext(int x)
        {
            return x + 1;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            //int[] output = new int[length];
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;

        }
    }
}