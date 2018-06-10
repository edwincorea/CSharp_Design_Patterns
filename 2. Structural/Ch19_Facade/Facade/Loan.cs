using System;

namespace Facade
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLoans(Student s)
        {
            Console.WriteLine("Verify loans for " + s.Name);
            return true;
        }
    }
}
