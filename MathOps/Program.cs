using System;

namespace MathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Subtract(756, 312, 54));
            Console.WriteLine(Multiply(324, 5, 6));
            Console.WriteLine(Divide(65, 5, 3));
            Console.WriteLine(Modulus(6534768, 1234, 345));
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

        private static int Subtract(params int[] input)
        {
            int output = 0;
            foreach (int i in input)
            {
                output -= i;
            }
            return output;
        }

        private static int Multiply(params int[] input)
        {
            int output = 0;
            foreach (int i in input)
            {
                output *= i;
            }
            return output;
        }

        private static double Divide(params double[] input)
        {
            double output = 0;
            foreach (double i in input)
            {
                output /= i;
            }
            return output;
        }

        private static int Modulus(params int[] input)
        {
            int output = 0;
            foreach (int i in input)
            {
                output %= i;
            }
            return output;
        }
    }
}
