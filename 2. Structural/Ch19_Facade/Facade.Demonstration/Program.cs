using System;

/// <summary>
/// This code demonstrates the Facade pattern as a MortgageApplication 
/// object which provides a simplified interface to a large subsystem 
/// of classes measuring the creditworthyness of an applicant.
/// </summary>
namespace Facade.Demonstration
{
    /// <summary>
    /// Facade Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Facade
            CollegeLoan collegeLoan = new CollegeLoan();

            // Evaluate loan
            Student student = new Student("Hunter Sky");
            bool eligible = collegeLoan.IsEligible(student, 75000);

            Console.WriteLine("\n" + student.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}