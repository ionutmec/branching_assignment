﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");

            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package lenght:");
                int packageLenght = Convert.ToInt32(Console.ReadLine());

                int shippingPrice = Convert.ToInt32(packageLenght) * Convert.ToInt32(packageHeight) * Convert.ToInt32(packageWidth) * Convert.ToInt32(packageWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + Convert.ToDecimal(shippingPrice));

                Console.ReadLine();







            }
        }
    }
}
