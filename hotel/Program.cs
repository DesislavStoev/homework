using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCounts = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May")
            {
                studioPrice = 50 * nightCounts;
                if (nightCounts > 7)
                {
                    studioPrice = (50 - 50 * 0.05) * nightCounts;
                }
                doublePrice = 65 * nightCounts;
                suitePrice = 75 * nightCounts;
            }
            else if (month == "June")
            {
                studioPrice = 60 * nightCounts;
                doublePrice = 72 * nightCounts;
                if (nightCounts > 14)
                {
                    doublePrice = (60 - 60 * 0.10) * nightCounts;
                }
                suitePrice = 82 * nightCounts;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightCounts;
                doublePrice = 77 * nightCounts;
                suitePrice = 89 * nightCounts;
                if (nightCounts > 14)
                {
                    suitePrice = (89 - 89 * 0.15) * nightCounts;
                }
            }
            else if (month == "October")
            {
                studioPrice = 50 *(nightCounts -1);
                if (nightCounts > 7)
                {
                    studioPrice = (50 - 50 * 0.05) * (nightCounts -1);
                    
                }
                doublePrice = 65 * nightCounts;
                suitePrice = 75 * nightCounts;
            }
            else if (month == "September")
            {
                studioPrice = 60 * (nightCounts -1 );
                
                doublePrice = 72 * nightCounts;
                if (nightCounts > 14)
                {
                    doublePrice = (72 - 72 * 0.1) * nightCounts;
                }
                suitePrice = 82 * nightCounts;
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");


        }
    }
}
