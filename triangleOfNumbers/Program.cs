using System;

namespace triangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < i-1; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}
