using System;

namespace cakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = "";
            int cnt = 0;
            while (ingredients != "Bake!" && ingredients.Length <=50)
            {
                ingredients = Console.ReadLine();
                if (ingredients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                    cnt++;
                }

                if (cnt >20)
                {
                    return;
                }

            }
            Console.WriteLine($"Preparing cake with {cnt} ingredients.");
        }
    }
}
