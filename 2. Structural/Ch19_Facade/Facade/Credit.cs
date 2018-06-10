using System;

namespace Facade
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    public class Credit
    {
        public bool HasGoodCredit(Student s)
        {
            Console.WriteLine("Verify credit for " + s.Name);
            return true;
        }
    }
}
