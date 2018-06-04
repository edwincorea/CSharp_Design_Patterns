using System;

/// <summary>
/// This is code  showing the adapter pattern for client company to get 
/// employee records for third party organizations whose interface is not 
/// compatible with client.
/// </summary>
namespace Adapter.Demonstration
{
    // 'Client' class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee list from 3rd party organization system.");
            Console.WriteLine("-------------------------------------------------");

            // Client will use ITarget interface to call functionality of 
            // Adaptee class i.e. ThirdPartyEmployee
            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}