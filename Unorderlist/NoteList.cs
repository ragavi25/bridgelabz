// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file= Unorderlist.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Datastructure
{
    public class NoteList<T>
    {

        private List<T> nodes = new List<T>();

        /// <summary>
        /// Add the Node
        /// </summary>
        /// <param name="newnode"></param>

        public void Add(T newnode)
        {
            nodes.Add(newnode);
        }
        /// <summary>
        /// Spicifed index  the node.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Indexof(T node)
        {
            int index1 = nodes.IndexOf(node);
            return index1;
        }
        /// <summary>
        /// This used to Remove the node.
        /// </summary>
        /// <param name="node"></param>
        public void Removenode(T node)
        {
            nodes.Remove(node);
        }

        public void Remove(T node)
        {
            nodes.Remove(node);
        }
        /// <summary>
        /// Inser the particular places.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        public void Insert(T v1, T v2)
        {
            nodes.Insert(1, v2);
        }
        /// <summary>
        /// All the print the values.
        /// </summary>
        public void printallnodes()
        {
            foreach (var a1 in nodes)
            {
                Console.WriteLine(a1.ToString());
            }
        }
        /// <summary>
        /// particular item searched.
        /// </summary>
        /// <param name="item"></param>
        public void Search(T item)
        {

            {
                if (nodes.Contains(item) == true)
                {
                    Console.WriteLine("Element is found");
                }
                else
                {
                    Console.WriteLine("Element is not found .so add the element");
                }

            }
        }
        /// <summary>
        ///  This used to empty or not
        /// </summary>
        public void isEmpty()
        {
            if (nodes.Count > 0)
            {
                Console.WriteLine("Element is not empty:");
            }
            else
            {
                Console.WriteLine("Element is empty");
            }
        }

       
        

        
    }
}


    