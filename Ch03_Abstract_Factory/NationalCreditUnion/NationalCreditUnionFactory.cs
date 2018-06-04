using Interfaces;
using System;

namespace NationalCreditUnion
{
    // Concrete Factory 2
    public class NationalCreditUnionFactory : CreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount nationalLoanAccount = new NationalLoanAccount();
            return nationalLoanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount nationalSavingsAccount = new NationalSavingsAccount();
            return nationalSavingsAccount;
        }
    }
}
