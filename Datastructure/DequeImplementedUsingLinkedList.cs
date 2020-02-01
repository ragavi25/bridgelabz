using System;

namespace Datastructure
{
    public class DequeImplementedUsingLinkedList<T>
    {

      private  Node<T> Front = null;
       private Node<T> Rear = null;
        private T data;
        private Node<T> next = null;
        private object rear;

        public object Frond { get; private set; }

        class Node<T>
        {
            internal DequeImplementedUsingLinkedList<T>.Node<T> next;
            T data;
            private T data1;
            public Node(T data1)
            {
                this.data1 = data1;
            }

            //public Node(T d)
            //{
              //  data = d;
            //}
        }

            public void removeFront()
            {
            Front = Front.next;
        }

        public void removeRear()
        {
            Node<T> previous;
            Node<T> current = Rear;

            while (current.next != null)
            {
                previous = current;
                current = current.next;
            }

            previous = Rear;
            previous.next = current.next;
        }

        public void GetFront()
            {
            Node<T> new_node = new Node<T> (data);

            if (Front != null)
            {
                new_node = Front.next;
                Front = new_node;
            }
        }

            public void GetRear()
            {
            Node<T> new_node = new Node<T>(data);

            while (Rear != null)
            {
                Rear = Rear.next;
            }

            rear = new_node;

        }

        public void insertRear(char v)
            {
            Node<T> new_node = new Node<T>(data);
            Rear = insertRear.new_Node;
            }
        }
    }
