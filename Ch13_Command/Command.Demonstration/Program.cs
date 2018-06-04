using System;

/// <summary>
/// This code demonstrates the Command pattern used in a simple calculator 
/// with unlimited number of undo's and redo's. Note that in C#  the 
/// word 'operator' is a keyword. Prefixing it with '@' allows using it 
/// as an identifier.
/// </summary>
namespace Command.Demonstration
{
    /// <summary>
    /// Command Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create user & let them compute
            User user = new User();

            // Use press calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
