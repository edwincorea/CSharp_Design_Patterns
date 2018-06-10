using System.Collections.Generic;

namespace DemoMemento
{
    public class Caretaker
    {

        // Where all mementos are saved

        List<Memento> savedStatements = new List<Memento>();

        // Adds memento to the collection

        public void AddMemento(Memento m) {
            savedStatements.Add(m);
        }

        // Gets the memento requested from the Collection

        public Memento GetMemento(int index) {
            if (index > -1)
            {
                return savedStatements[index];
            }
            else {
                return new Memento(string.Empty);
            }
            
        }
    }
}
