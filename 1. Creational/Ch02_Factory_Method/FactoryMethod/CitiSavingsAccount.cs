namespace FactoryMethod
{
    // Concrete Product
    public class CitiSavingsAccount : SavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
}
