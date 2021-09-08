using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(),
                new Cortado(),
                new BlackCoffee()

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine(coffee.ToString());
            }

            List<IMilk> coffeeWithMilk = new List<IMilk>()
            {
                new Latte(),
                new Cortado()

            };

            foreach(var item in coffeeWithMilk)
            {
                Console.WriteLine($"The amount if milk used is: {item.mlMilk()}");
            }

            foreach(var item in orderList)
            {
                if(item is IMilk)
                {
                    IMilk cItem = item as IMilk;
                    Console.WriteLine("See me as a IMilk object");
                    Console.WriteLine($"The amount of milk used {cItem.mlMilk()}");
                }
                else
                {
                    Console.WriteLine("I'm not milk.");
                }

                if(item is ICoffeeBlend)
                {
                    ICoffeeBlend cItem = item as ICoffeeBlend;
                    Console.WriteLine("see me as an ICoffeBlend object");
                    Console.WriteLine($"CoffeBlend:  {cItem.CoffeeBlend()}");

                }
                else
                    Console.WriteLine("I'm not ICoffeeBlend");
                Console.WriteLine(item.ToString());
            }

        }
    }
}
