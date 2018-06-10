using System;

namespace Flyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Triangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Triangle");
        }
    }
}
