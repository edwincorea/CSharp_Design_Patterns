namespace FactoryMethod
{
    // Creator
    public interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
