using System;

namespace Simula_s_Soups
{
    class Program
    {
        static void Main(string[] args)
        {
            (Food food, Ingredient ingredient, Seasoning seasoning)[] soup = new (Food, Ingredient, Seasoning)[3];
            soup[0].Item1 = Food.Soup;
            soup[1].Item1 = Food.Stew;
            soup[2].Item1 = Food.Gumbo;

            for (int i = 0; i < 3; i++) {

                Console.WriteLine("---------------------------------------------------------");

                int ingredientSelection;
                bool loop1Completed = false;
                do
                {
                    loop1Completed = true;
                    Console.Write($"Select {i + 1}. food ingredient: \n1. Mushroom \n2. Chicken \n3. Carrots \n4. Potatoes\n> ");
                    ingredientSelection = Convert.ToInt32(Console.ReadLine());

                    switch (ingredientSelection)
                    {
                        case 1:
                            soup[i].Item2 = Ingredient.Mushroom;
                            break;

                        case 2:
                            soup[i].Item2 = Ingredient.Chicken;
                            break;

                        case 3:
                            soup[i].Item2 = Ingredient.Carrots;
                            break;

                        case 4:
                            soup[i].Item2 = Ingredient.Potatoes;
                            break;

                        default:    
                            Console.WriteLine("Wrong Selection. Try Again.");
                            loop1Completed = false;
                            break;
                    }

                } while (!loop1Completed);


                Console.WriteLine("---------------------------------------------------------");

                int seasoningSelection;
                bool loop2Completed = false;
                do
                {
                    loop2Completed = true;
                    Console.Write($"Select {i + 1}. food seasoning: \n1. Spicy \n2. Salty \n3. Sweet \n> ");
                    seasoningSelection = Convert.ToInt32(Console.ReadLine());

                    switch (seasoningSelection)
                    {
                        case 1:
                            soup[i].Item3 = Seasoning.Spicy;
                            break;

                        case 2:
                            soup[i].Item3 = Seasoning.Salty;
                            break;

                        case 3:
                            soup[i].Item3 = Seasoning.Sweet;
                            break;

                        default:
                            Console.WriteLine("Wrong Selection. Try Again.");
                            loop2Completed = false;
                            break;
                    }

                } while (!loop2Completed);

            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{soup[i].seasoning} {soup[i].ingredient} {soup[i].food}");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
        }

        enum Food { Soup, Stew, Gumbo }
        enum Ingredient { Mushroom, Chicken, Carrots, Potatoes }
        enum Seasoning { Spicy, Salty, Sweet }
    }
}
