using Interfaces;
using System;

namespace CitiCreditUnion
{
    // Concrete ProductA1
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }
}
