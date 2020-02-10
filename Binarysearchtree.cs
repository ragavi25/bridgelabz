// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Binarysearchtree.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
    class Binarysearchtree
    {
        public void Binarysearch()
        {
            BinaryTree binarytree = new BinaryTree();
            binarytree.Insert(75);
            binarytree.Insert(57);
            binarytree.Insert(32);
            binarytree.Insert(60);
            binarytree.Insert(7);
            binarytree.Insert(44);
            binarytree.Insert(90);
            binarytree.Insert(87);
            binarytree.Insert(99);
            Console.WriteLine("In order Traversal(Left->Root->right");
            binarytree.Inordertraversal();
            Console.WriteLine("\n preordertraversal (Root->left->right");
            binarytree.Preordertraversal();
            Console.WriteLine("\n postordertrvaesal (left->right->root");
            binarytree.Postordertraversal();
            Console.WriteLine("\n find 90");
            var node = binarytree.Find(90);
            Console.WriteLine(node.Data);
            Console.WriteLine("Find Recursively 90");
            var noder = binarytree.FindRecursive(90);
            Console.Write(noder.Data);
            Console.WriteLine("Delete a leafnode 44");
            binarytree.Remove(44);
            Console.WriteLine("Delete both childroot ");
            binarytree.Remove(75);




        }
    }
}
