using System;

namespace Datastructure
{
    public class TreeNode
    {
        private readonly int data;
       public TreeNode rightNode;
        public TreeNode leftNode;

        public int Data { get; internal set; }

        public TreeNode(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if(value >=data)
            {
                if(rightNode==null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if(leftNode==null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
            
        }

           public void Postordertraversal()
        {
            if (leftNode != null)
            {
                leftNode.Preordertraversal();
            }
            if (rightNode != null)
            {
                rightNode.Preordertraversal();
            }
            Console.WriteLine(data + " ");

        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;
            while(currentNode !=null)
            {
                if(value==currentNode.data )
                {
                    return currentNode;
                }
                else if(value >currentNode.data)
                {
                    currentNode = currentNode.rightNode;

                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
                
            }
            return null;
        }
        public TreeNode FindRecursive(int value)
        {
            if (value == data)

            {
                return this;
            }
            else if(value <data && leftNode!=null)
            {
                return leftNode.FindRecursive(value);
            }
            else if(rightNode!=null)
                {
                return rightNode.FindRecursive(value);

            }
            else
            {
                return null;
            }

        }

        public void Preordertraversal()
        {
            Console.WriteLine(data + " ");
            if(leftNode !=null)
            {
                leftNode.Preordertraversal();
            }
            if(rightNode !=null)
            {
                rightNode.Preordertraversal();
            }
        }

        public void Inordertraversal()
        {
           if(leftNode !=null)
            {
                leftNode.Inordertraversal();
            }
        }
    }
}