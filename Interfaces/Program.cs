using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            car.Move();

            Bicycle bicycle = new Bicycle();
            bicycle.Move();
        }
    }
}
