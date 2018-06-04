namespace Interfaces
{
    // Abstract Factory
    public abstract class CreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }    
}
