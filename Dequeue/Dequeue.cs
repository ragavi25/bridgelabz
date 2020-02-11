using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Dequeue<D>
    {
        Node front;
        Node rear;
        int count = 0;
        internal void AddFront(D data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                rear = newNode;
                count++;
            }
            else
            {
                front.previous = newNode;
                count++;
            }
            newNode.Next = front;
            front = newNode;
        }
        internal void AddRear(D data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                front = node;
                count++;
            }
            else
            {
                rear.Next = node;
                node.previous = rear;
                count++;
            }
            rear = node;
        }
        internal D RemoveFront()
        {
            D sa = (D)front.Data;
            if (front.Next == null)
            {
                rear = null;

            }
            else
            {
                front.Next.previous = null;
                count--;
            }
            front = front.Next;
            return sa;
        }
        internal D RemoveRear()
        {
            D ele = (D)rear.Data;
            if (front.Next == null)
            {
                front = null;
                count--;
            }
            else
            {
                rear.previous.Next = null;
            }
            rear = rear.previous;
            count--;

            return ele;
        }
        public Boolean IsEmpty()
        {
            return (front == null);
        }
        public int Size()
        {
            return count;
        }
        internal void PrintDeQueue()
        {
            Node n = front;
            if (front == null)
            {
                Console.WriteLine("Dequeue is empty");
            }
            else
            {
                while (n != null)
                {
                    Console.WriteLine(n.Data);
                    n = n.Next;
                }
            }
        }
        public static void Dequeuetest()
        {
            Dequeue<string> dequeue = new Dequeue<string>();
            Console.WriteLine("enter number of elements");
            int num = Utility.number();
            for (int i = 0; i < num; i++)
            {
                dequeue.AddFront(Utility.UserString());
            }
            Console.WriteLine("enter number of elements");
            num = Utility.number();
            for (int i = 0; i < num; i++)
            {
                dequeue.AddRear(Utility.UserString());
            }
            Console.WriteLine("enter number of elements");
            num = Utility.number();
            for (int i = 0; i < num; i++)
            {
                dequeue.AddFront(Utility.UserString());
            }
            Console.WriteLine(dequeue.RemoveFront());
            Console.WriteLine(dequeue.RemoveRear());
            Console.WriteLine(dequeue.Size());

            dequeue.PrintDeQueue();
        }
    }
}
