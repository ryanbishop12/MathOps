using System;

namespace MathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Sum(100, 50));
            Console.WriteLine();

            Console.WriteLine(Subtract(756, 312, 54));
            Console.WriteLine(Subtract(4,7));
            Console.WriteLine();

            Console.WriteLine(Multiply(324, 5, 6));
            Console.WriteLine(Multiply(42, 5));
            Console.WriteLine();

            Console.WriteLine(Divide(65, 5, 3));
            Console.WriteLine(Divide(145, 2));
            Console.WriteLine();

            Console.WriteLine(Modulus(6534768, 1234, 345));
            Console.WriteLine(Modulus(153,2));
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
            int output = input[0];
            for (int x = 1; x < input.Length; x++)
            {
                output -= input[x];
            }
            return output;
        }

        private static int Multiply(params int[] input)
        {
            int output = input[0];
            for (int x = 1; x < input.Length; x++)
            {
                output *= input[x];
            }
            return output;
        }

        private static double Divide(params double[] input)
        {
            double output = input[0];
            for (int x = 1; x < input.Length; x++)
            {
                output /= input[x];
            }
            return output;
        }

        private static int Modulus(params int[] input)
        {
            int output = input[0];
            for (int x = 1; x < input.Length; x++)
            {
                output %= input[x];
            }
            return output;
        }
    }
}
