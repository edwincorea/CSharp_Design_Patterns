using System;

/// <summary>
/// This code demonstrates the composite pattern for an application where 
/// any employee can see their own performance record. The supervisor can 
/// see their own and their subordinate’s performance record
/// </summary>
namespace Composite.Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ricky =
                new Employee { EmployeeID = 1, Name = "ricky", Rating = 3 };

            Employee mike =
                new Employee { EmployeeID = 2, Name = "mike", Rating = 4 };

            Employee maryann =
                new Employee { EmployeeID = 3, Name = "maryann", Rating = 5 };

            Supervisor ronny =
                new Supervisor { EmployeeID = 7, Name = "ronny", Rating = 3 };

            ronny.AddSubordinate(ricky);
            ronny.AddSubordinate(mike);
            ronny.AddSubordinate(maryann);

            Employee ginger =
                new Employee { EmployeeID = 4, Name = "ginger", Rating = 3 };

            Employee olive =
                new Employee { EmployeeID = 5, Name = "olive", Rating = 4 };

            Employee candy =
                new Employee { EmployeeID = 6, Name = "candy", Rating = 5 };

            Supervisor bobby =
                new Supervisor { EmployeeID = 8, Name = "bobby", Rating = 3 };

            bobby.AddSubordinate(ginger);
            bobby.AddSubordinate(olive);
            bobby.AddSubordinate(candy);

            Console.WriteLine("\n--- Employee can see their Performance " +
                "Summary --------");
            ricky.PerformanceSummary();

            Console.WriteLine("\n--- Supervisor can also see their " +
                "subordinates performance summary-----");
            ronny.PerformanceSummary();

            Console.WriteLine("\nSubordinate Performance Record:");
            foreach (Employee employee in ronny.ListSubordinates)
            {
                employee.PerformanceSummary();
            }

            Console.ReadLine();
        }
    }
}
