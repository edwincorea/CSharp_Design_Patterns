using System;

/// <summary>
/// This code demonstrates the bridge pattern by sending messages using 
/// two independent systems. One by text & the other, webservice.
/// </summary>
namespace Bridge.Demonstration
{
    class Program
    {
        /// <summary>
        /// Bridge Design Pattern Demo
        /// </summary>
        static void Main(string[] args)
        {
            IMessageSender text = new TextSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage
            {
                Subject = "A Message",
                Body = "Hi there, Please accept this message."                
            };
            message.MessageSender = text;
            message.Send();

            message.MessageSender = web;
            message.Send();

            Console.ReadKey();
        }
    }
}
