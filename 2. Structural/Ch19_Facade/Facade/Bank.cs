using System;

namespace Facade
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class Bank
    {
        public bool HasSufficientSavings(Student s, int amount)
        {
            Console.WriteLine("Verify bank for " + s.Name);
            return true;
        }
    }
}
