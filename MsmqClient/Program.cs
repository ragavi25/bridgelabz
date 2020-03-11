using Experimental.System.Messaging;
using System;

namespace MsmqClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latest Message");
            MessageQueue Myqueue;
            Myqueue = new MessageQueue(@".\private$\Myqueue");
            Message message = Myqueue.Receive();
            message.Formatter = new BinaryMessageFormatter();
            Console.WriteLine(message.Body.ToString());
            Console.ReadLine();

        }
    }
}
