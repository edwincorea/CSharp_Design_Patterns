using System;
using System.Collections.Generic;

/// <summary>
/// This code demonstrates the Interpreter pattern which is used to change 
/// a Roman numbers to decimal.
/// </summary>
namespace Interpreter.Demonstration
{
    /// <summary> 
    /// Interpreter Design Pattern.
    /// </summary>
    class Program
    {
        static void Main()
        {
            string roman = "MMXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");

            // Wait for user
            Console.ReadKey();
        }
    }
}
