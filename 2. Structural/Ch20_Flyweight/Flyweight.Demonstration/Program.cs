using System;

/// <summary>
/// This code demonstrates the Flyweight pattern in which a relatively 
/// small number of shape objects is shared several times.
/// </summary>
namespace Flyweight.Demonstration
{
    /// <summary>
    /// Flyweight Design Pattern.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Triangle");
            shape.Print();

            shape = sof.GetShape("Triangle");
            shape.Print();

            shape = sof.GetShape("Triangle");
            shape.Print();

            shape = sof.GetShape("Square");
            shape.Print();

            shape = sof.GetShape("Square");
            shape.Print();

            shape = sof.GetShape("Square");
            shape.Print();

            int total = sof.TotalObjectsCreated;
            Console.WriteLine($"\n Number of objects created = {total}");

            Console.ReadKey();
        }
    }
}
