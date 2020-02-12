namespace Object_oriented_programs
{
    internal class LinkedListNode
    {
        private string key;
        public LinkedListNode next;
      
        // constructor to create 
        // a new linked list node 
        

        public LinkedListNode(string key)
        {
            this.key = key;
            this.next = null;
        }

    }
}