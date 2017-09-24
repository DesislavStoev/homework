using System;

namespace chooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            

            if (profession == "Athlete")
            {
                totalPrice = 0.70 * quantity;
                
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = 1.00 * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = 1.70 * quantity;
            }
            else
            {
                totalPrice = 1.20 * quantity;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
