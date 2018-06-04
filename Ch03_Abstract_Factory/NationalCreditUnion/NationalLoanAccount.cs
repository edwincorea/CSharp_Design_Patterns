using Interfaces;
using System;

namespace NationalCreditUnion
{
    // ProductB2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
}
