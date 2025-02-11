using System;

namespace SquareProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the square (x1, y1, x2, y2, x3, y3, x4, y4): ");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("x3 = ");
            double x3 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("x4 = ");
            double x4 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("y4 = ");
            double y4 = double.Parse(Console.ReadLine() ?? "0");
            //create new object Square
            Square square = new Square(x1, y1, x2, y2, x3, y3, x4, y4);

            Console.WriteLine("\n The square has coordinates:");
            Console.WriteLine($" A({square.X1}, {square.Y1})");
            Console.WriteLine($" B({square.X2}, {square.Y2})");
            Console.WriteLine($" C({square.X3}, {square.Y3})");
            Console.WriteLine($" D({square.X4}, {square.Y4})");

            if(square.CheckEqualSides())
            {
                Console.WriteLine("\nThis is a square :D.");

                double perimeter = square.ResPerimeter();
            Console.WriteLine($"\nPerimeter: {perimeter}");

            double area = square.ResArea();
            Console.WriteLine($"Area: {area}");

            Console.WriteLine("\nClick the button to turn off...");
            Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nThis is not a square -_-.");
                Console.ReadKey();
            }


        }     
    }
}