using System;

namespace restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            bool isValidGroup = true;

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                if (package == "Normal")
                {
                    price = (2500 + 500 - (2500 + 500) * 0.05) / groupSize;
                }
                else if (package == "Gold")
                {
                    price = (2500 + 750 - (2500 + 750) * 0.1) / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = (2500 + 1000 - (2500 + 1000) * 0.15) / groupSize;
                }
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                if (package == "Normal")
                {
                    price = (5000 + 500 - (5000 + 500) * 0.05) / groupSize;
                }
                else if (package == "Gold")
                {
                    price = (5000 + 750 - (5000 + 750) * 0.1) / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = (5000 + 1000 - (5000 + 1000) * 0.15) / groupSize;
                }
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                if (package == "Normal")
                {
                    price = (7500 + 500 - (7500 + 500) * 0.05) / groupSize;
                }
                else if (package == "Gold")
                {
                    price = (7500 + 750 - (7500 + 750) * 0.1) / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = (7500 + 1000 - (7500 + 1000) * 0.15) / groupSize;
                }
            }
            else
            {
                isValidGroup = false;
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (isValidGroup)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {price:f2}$");
            }
        }
    }
}
