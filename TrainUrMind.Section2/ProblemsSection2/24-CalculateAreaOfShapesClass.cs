using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CalculateAreaOfShapesClass
    {
        public static double CalculateArea(int choice, double parameter1, double parameter2 = 0)
        {
            switch (choice)
            {
                case 1:
                    return Math.PI * Math.Pow(parameter1, 2);
                case 2:
                    return parameter1 * parameter2;
                case 3:
                    return 0.5 * parameter1 * parameter2;
                default:
                    return -1;
            }
        }
    }
}
/*
 * 
 *  Console.WriteLine("Choose a shape to calculate area:");
                    Console.WriteLine("1. Circle");
                    Console.WriteLine("2. Rectangle");
                    Console.WriteLine("3. Triangle");
                    int shapeChoice = int.Parse(Console.ReadLine());

                    switch (shapeChoice)
                    {
                        case 1:
                            Console.WriteLine("Input radius of the circle:");
                            double radius = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, radius));
                            break;
                        case 2:
                            Console.WriteLine("Input length of the rectangle:");
                            double length = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input width of the rectangle:");
                            double width = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, length, width));
                            break;
                        case 3:
                            Console.WriteLine("Input base length of the triangle:");
                            double baseLength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input height of the triangle:");
                            double height = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, baseLength, height));
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;
 * */