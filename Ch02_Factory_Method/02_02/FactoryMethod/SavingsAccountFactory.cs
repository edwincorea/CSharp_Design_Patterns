using System;

namespace FactoryMethod
{
    // Concrete Creators
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public SavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI")) {
                return new CitiSavingsAccount();
            }
            else if (acctNo.Contains("NATIONAL")) {
                return new NationalSavingsAccount();
            }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
