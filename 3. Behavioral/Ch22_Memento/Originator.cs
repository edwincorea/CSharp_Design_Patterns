using System;
using static System.Diagnostics.Debug;

namespace DemoMemento
{

    public class Originator
    {

        private String statement;

        // Sets the value for the statement

        public void Set(String newStatement)
        {
            WriteLine("----");
            WriteLine("From Originator: Current Version of Statement\n" 
                + newStatement + "\n");
            this.statement = newStatement;
        }

        // Creates a new Memento with a new statement

        public Memento StoreInMemento()
        {
            WriteLine("From Originator: Saving to Memento");
            return new Memento(statement);
        }

        // Gets the statement currently stored in memento

        public String RestoreFromMemento(Memento memento)
        {

            statement = memento.GetState();

            WriteLine("From Originator: Previous Statement Saved in Memento\n" + statement + "\n");

            return statement;

        }
    }
}
