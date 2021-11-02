using System;

namespace Kruh_IT1B
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection;
            double radius;
            double diameter;
            while (true)
            {
                Console.Clear();
                menuSelection = Menu();
                if (menuSelection == 1)
                {
                    radius = UserInputRadius();
                    Console.WriteLine(GetCircumference(radius, true));
                    Console.WriteLine(GetContent(radius, true));
                }
                else
                {
                    diameter = UserInputDiameter();
                    Console.WriteLine(GetCircumference(diameter, false));
                    Console.WriteLine(GetContent(diameter, false));
                }
                Console.ReadLine();
            }            
        }

        static int Menu()
        {
            Console.WriteLine(" CIRCLE");
            Console.WriteLine("---------------");
            Console.WriteLine(" 1 - enter radius");
            Console.WriteLine(" 2 - enter diameter");
            return int.Parse(Console.ReadLine());
        }

        static double UserInputRadius()
        {
            Console.Write(" Enter radius value: ");
            return double.Parse(Console.ReadLine());
        }

        static double UserInputDiameter()
        {
            Console.Write(" Enter diameter value: ");
            return double.Parse(Console.ReadLine());
        }

        static string GetCircumference(double value, bool isRadius)
        {
            if (isRadius)
            {
                return $"o = {Math.Round(2 * Math.PI * value, 2)}";
            }
            else
            {
                return $"o = {Math.Round(Math.PI * value, 2)}";
            }
        }

        static string GetContent(double value, bool isRadius)
        {
            if (isRadius)
            {
                return $"S = {Math.Round(Math.PI * value * value, 2)}";
            }
            else
            {
                return $"S = {Math.Round(Math.PI * ((value * value) / 4), 2)}";
            }
        }
    }
}
