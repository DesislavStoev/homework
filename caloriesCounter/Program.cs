using System;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientCount = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 0; i < ingredientCount; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient.Contains("cheese"))
                {
                    totalCalories += 500;
                }
                else if (ingredient.Contains("tomato sauce"))
                {
                    totalCalories += 150;
                }
                else if (ingredient.Contains("salami"))
                {
                    totalCalories += 600;
                }
                else if (ingredient.Contains("pepper"))
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
