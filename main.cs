// Created by: Allen
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseAOfTrapzoid;
        int baseBOfTrapzoid;
        int heightOfTrapzoid;
        int areaOfTrapzoid;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the base A (cm): ");
        baseAOfTrapzoid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the base B (cm): ");
        baseBOfTrapzoid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        heightOfTrapzoid = Convert.ToInt32(Console.ReadLine());

        areaOfTrapzoid = ((baseAOfTrapzoid + baseBOfTrapzoid) / 2) * heightOfTrapzoid;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + areaOfTrapzoid + " cm². ");

        Console.WriteLine("\nDone.");
    }
}
