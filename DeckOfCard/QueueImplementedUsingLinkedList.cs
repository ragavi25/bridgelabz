using System;
using System.Collections;
using System.Collections.Generic;

namespace Object_oriented_programs
{
    public class QueueImplementedUsingLinkedList<T>
    {
        private List<T> nodes = new List<T>();
        public string key;
        LinkedListNode front, rear;
        public QueueImplementedUsingLinkedList()
        {
            this.front = this.rear = null;
        }

public  void enqueue(string key)
        {
            // Create a new LL node 
            LinkedListNode temp = new LinkedListNode(key);

            // If queue is empty, then new 
            // node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the 
            // end of queue and change rear 
            this.rear.next = temp;
            this.rear = temp;
        }

       
        public void dequeue()
        {
            

        }

        public int Count()
        {

            return 0;
        }
    }
}