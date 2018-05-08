using FactoryMethod;
using System;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My Citi Balance is {citiAcct.Balance.ToString("C")} " +
                $"and National Balance is {nationalAcct.Balance.ToString("C")}");
        }
    }
}
