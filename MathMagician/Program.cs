﻿using System;
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
            string prompt = "OK";
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string response = Console.ReadLine();
            if (response =="natural numbers")
            {
                Console.WriteLine("How many?");
                Console.WriteLine(prompt);
                int length;
                string response_length = Console.ReadLine();
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                  NaturalNumbers nats = new NaturalNumbers();
                  nats.ToString(nats.GetSequence(length));
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