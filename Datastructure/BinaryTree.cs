using System;

namespace Datastructure
{
    public class BinaryTree
    {
        private TreeNode root;
       


        public void Insert(int data)
        {
            if(root !=null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void Inordertraversal()
        {
            if(root!=null)
            {
                root.Inordertraversal();
            }
        }

        public void Preordertraversal()
        {
         if(root !=null)
            {
                root.Preordertraversal();
            }
        }

        public void Postordertraversal()
        {
          if(root!=null)
            {
                root.Postordertraversal();
            }
        }

        public TreeNode Find(int data)
        {
            if(root!=null)
            {
                return root.Find(data);
            }
            else
            {
                ////if the root is null so we return null nothing to find
                return null;
            }
        }

        public TreeNode FindRecursive(int data)
        {

            if (root != null)
            { 
                return root.FindRecursive(data);
            }
            else
            {
                ////if the root is null so we return null nothing to find
                return null;
            }
        }

        public void Remove(int data)
        {
            TreeNode current = root;
            TreeNode parent = root;
            bool isLeftchild = false;
            if( current==null && current.Data!=data)
            {
                return;
            }
            while(current !=null)
            {
                parent = current;
                if(data < current.Data)
                {
                    current = current.leftNode;
                    isLeftchild = true;
                }
                else
                {
                    current = current.rightNode;
                    isLeftchild = false;
                }
            }
            if(current ==null)
            {
                return;
            }
            if (current.rightNode == null && current.leftNode == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else
                {
                    if (isLeftchild)
                    {
                        parent.leftNode = null;
                    }
                    else
                    {
                        parent.rightNode = null;
                    }
                }
            }
            else if (current.rightNode == null)
            {
                if (current == root)
                {
                    root = current.leftNode;
                }
                else
                {
                    if (isLeftchild)
                    {
                        parent.leftNode = null;
                    }
                    else
                    {
                        parent.rightNode = null;
                    }
                }
            }
            else if (current.leftNode == null)
            {
                if (current == root)
                {
                    root = current.rightNode;
                }
                else
                {
                    if (isLeftchild)
                    {
                        parent.leftNode = current.rightNode;
                    }
                    else
                    {
                        parent.rightNode = current.leftNode;
                    }
                }
            }
            else////both deleted rootnode
            {
                TreeNode success = GetSuccesor(current);
                if (current == root)
                {
                    root = success;
                }
                else if (isLeftchild)
                {
                    parent.leftNode = success;
                }
                else
                {
                    parent.rightNode = success;
                }
            }
        }

        private TreeNode GetSuccesor(TreeNode node)
        {
            TreeNode parentofsuccesor = node;
            TreeNode succesor = node;
            TreeNode current = node.rightNode;
            while(current !=null)
            {
                parentofsuccesor = node;
                succesor = current;
                current = current.leftNode;
            }
            if(succesor !=node.rightNode)
            {
                parentofsuccesor.leftNode = succesor.rightNode;
                succesor.rightNode = node.rightNode;
            }
            succesor.leftNode = node.leftNode;
            return succesor;
        }
    }
}