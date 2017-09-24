using System;

namespace testNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int cnt = 0;
            for (int i = n; i > 0; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    cnt++;
                    sum += 3 * (i * k);
                    if (sum >= stopNumber)
                    {
                        Console.WriteLine($"{cnt} combinations");
                        Console.WriteLine($"Sum: {sum} >= {stopNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{cnt} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
