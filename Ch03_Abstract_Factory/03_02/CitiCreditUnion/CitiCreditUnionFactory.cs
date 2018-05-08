using Interfaces;
using System;

namespace CitiCreditUnion
{
    // Concrete Factory 1
    public class CitiCreditUnionFactory : CreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            CitiLoanAccount citiLoanAccount = new CitiLoanAccount();
            return citiLoanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            CitiSavingsAccount citiSavingsAccount = new CitiSavingsAccount();
            return citiSavingsAccount;
        }
    }
}
