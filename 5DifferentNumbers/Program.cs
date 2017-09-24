using System;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
           
            if (secondNum - firstNum < 5)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int k = firstNum; k <= secondNum; k++)
                {
                    for (int j = firstNum; j <= secondNum; j++)
                    {
                        for (int f = firstNum; f <= secondNum; f++)
                        {
                            for (int p = firstNum; p <= secondNum; p++)
                            {
                                if (firstNum <= i && i < k && k < j && j < f && f < p && p <= secondNum)
                                {
                                    Console.WriteLine($"{i} {k} {j} {f} {p}");
                                }
                                
                            }
                        }
                    }
                }
            }
           
           
        } 
    }
}
