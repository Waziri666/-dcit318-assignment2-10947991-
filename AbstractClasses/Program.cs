using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5);
            Console.WriteLine($"Area of circle: {circle.GetArea()}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}");
        }
    }
}
