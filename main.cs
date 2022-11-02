// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program calculates the area of a pyramid
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;

        Console.WriteLine("This program calculates the volume of a pyramid");
        Console.Write("\nEnter radius a in cm: ");
        radius = Convert.ToInt32(Console.ReadLine());
        volume = (4.0 * Math.PI * Math.Pow(radius, 3)) / 3.0;
        Console.WriteLine("\nThe volume is: " + volume.ToString("0.00") + " cm³. ");
    }
}