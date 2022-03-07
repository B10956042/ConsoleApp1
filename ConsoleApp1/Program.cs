using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total_cost = 0;
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            total_cost = meal_cost + tip_percent + tax_percent;
            Console.WriteLine(total_cost);
            meal_cost = 12.0;
            tip_percent = 20;
            tax_percent = 8;
            total_cost = meal_cost + tip_percent + tax_percent;
            Console.WriteLine(total_cost);
        }
    }
}
