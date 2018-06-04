using Interfaces;
using System;

namespace NationalCreditUnion
{
    // ProductA2
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }
}
