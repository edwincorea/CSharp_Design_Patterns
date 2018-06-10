using System;

namespace Flyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Square : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Square");
        }
    }
}
