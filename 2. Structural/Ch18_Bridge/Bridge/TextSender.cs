using System;

namespace Bridge
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class TextSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            string messageType = "Text";
            Console.WriteLine($"{messageType}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Subject:  {subject} from {messageType}\nBody:  {body}\n");
        }
    }
}
