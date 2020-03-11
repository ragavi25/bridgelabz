using Experimental.System.Messaging;
using System;

namespace Msmq
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Message to be send");
            Console.WriteLine("Higher Priority message should be start 'hp:')");
            string msg = Console.ReadLine();
            MessageQueue Myqueue;
            ////Get a MessageQueue
            if (MessageQueue.Exists(@".\private$\Myqueue"))
            {
                Myqueue = new MessageQueue(@".\private$\Myqueue");
            }
            else
            {
                Myqueue =  MessageQueue.Create(@".\private$\Myqueue");
            }
            Message message = new Message();
            message.Formatter = new BinaryMessageFormatter();
            message.Body = msg;
            message.Label = "MsmqMessage";
            if(msg.Contains("hp:"))
            {
                message.Priority = MessagePriority.High;
            }
            else
            {
                message.Priority = MessagePriority.Low;
            }
            Myqueue.Send(message);
            Console.WriteLine("Thanks for sending message");
            Console.ReadKey();

        }

    }
}
