﻿using System;

namespace PizzaAlgoExpanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, there! Let's order a pizza, or two.");
            Console.WriteLine("");
            Console.WriteLine("Where do you live? What place (state, city, etc.) did you want to order a pizza from?");
            string pizzaPlace;
            pizzaPlace = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Great. What pizza brand do you like best?");
            string pizzaBrand;
            pizzaBrand = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Ah, so you favor the {pizzaBrand} pizza. Sounds good to me!");
            Console.WriteLine("");
            Console.WriteLine($"So, we're ordering our first pizza from {pizzaPlace}. What kind of toppings did you want for it?");
            string pizzaToppings;
            pizzaToppings = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"{pizzaToppings}, what a tasty choice! Now, hopefully, you will enjoy your pizza.... How soon did you want it (number)?");
            string pizzaTime;
            pizzaTime = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Alright. So you've now ordered a pizza with {pizzaToppings} from {pizzaBrand}, which is based out of, {pizzaPlace}, and it should be ready in about {pizzaTime} minutes.");
        }
    }
}
