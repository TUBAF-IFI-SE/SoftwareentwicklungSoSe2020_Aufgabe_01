using System;

namespace FernerPlanet
{
    class Program
    {
        static void Main(String[] args)
        {
            //variables
            string name;
            int num;
            string cat;
            double lum;

            //input
            Console.WriteLine("How do you name your creature?");
            Console.Write("name: ");
            name = Console.ReadLine();
            Console.WriteLine("And what is the registry number of " + name + "?");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There are more " + name + " with this registry number. To which category belongs this " + name + "?");
            cat = Console.ReadLine();
            Console.WriteLine("What is the luminosity of " + name + " " + num + cat.ToUpper() + " in lf?");
            lum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("complete....");


            //output
            Console.WriteLine("The " + name + " " + num + cat.ToUpper() + " has a luminosity of " + lum + "lf.");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Registry number: " + num);
            Console.WriteLine("Category: " + cat.ToUpper());
            Console.WriteLine("Luminosity: " + lum + "lf");

            Console.ReadLine();
        }
    }
}
