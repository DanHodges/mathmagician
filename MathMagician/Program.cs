using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "1.) Natural Numbers\n2.) Even Numbers\n3.) Odd Numbers\n4.) Prime Numbers\n5.) Fibonacci Numbers\n";
            Console.Write("What do you want me to do? \n");
            Console.Write(prompt);
            string response = Console.ReadLine();
            if (response == "1")
            {   //Natty
                Console.WriteLine("How many?");
                //Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                  NaturalNumbers nats = new NaturalNumbers();
                  Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                }
            }
            else if (response == "2")
            {   //Even
                Console.WriteLine("How many?");
                //Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    EvenNumbers Even = new EvenNumbers();
                    Console.WriteLine(Even.ToString(Even.GetSequence(length)));
                }
            }
            else if (response == "3")
            {   //Odd
                Console.WriteLine("How many?");
                //Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    OddNumbers Odd = new OddNumbers();
                    Console.WriteLine(Odd.ToString(Odd.GetSequence(length)));
                }
            }
            else if (response == "4")
            {   //Prime
                Console.WriteLine("How many?");
                //Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    PrimeNumbers primes = new PrimeNumbers();
                    Console.WriteLine(primes.ToString(primes.GetSequence(length)));
                }
            }
            else if (response == "5")
            {   //Fib
                Console.WriteLine("How many?");
                //Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    FibNumbers fibs = new FibNumbers();
                    Console.WriteLine(fibs.ToString(fibs.GetSequence(length)));
                }
             }
             else
             {
                Console.WriteLine("Whoops! Try a number next time.");
             }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}