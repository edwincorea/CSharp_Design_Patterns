using System;

namespace Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class NonActor : Participant
    {
        // Constructor
        public NonActor(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Actor: ");
            base.Receive(from, message);
        }
    }
}
