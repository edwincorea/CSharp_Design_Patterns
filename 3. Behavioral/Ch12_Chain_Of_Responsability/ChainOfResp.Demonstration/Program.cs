using System;

/// <summary>
/// This code demonstrates the Chain of Responsibility pattern in which 
/// several linked managers and executives can respond to a purchase 
/// request or hand it off to a superior. Each position has can have 
/// its own set of rules which orders they can approve.
/// </summary>
namespace ChainOfResp.Demonstration
{
    /// <summary>
    /// Chain of Responsibility Design Pattern.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Setup Chain of Responsibility
            Approver ronny = new Director();
            Approver bobby = new VicePresident();
            Approver ricky = new President();

            ronny.SetSuccessor(bobby);
            bobby.SetSuccessor(ricky);

            // Generate and process purchase requests
            Purchase p = new Purchase(8884, 350.00, "Assets");
            ronny.ProcessRequest(p);

            p = new Purchase(5675, 33390.10, "Project Poison");
            ronny.ProcessRequest(p);

            p = new Purchase(5676, 144400.00, "Project BBD");
            ronny.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
