using System;

namespace MathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static int Sum(params int[] input)
        {
            int output = 0;
            foreach(int i in input)
            {
                output += i;
            }
            return output;
        }

    }
}
