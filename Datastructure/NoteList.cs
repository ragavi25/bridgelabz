﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Unorderlist.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Datastructure
{
    public class NoteList<T>
    {

        private List<T> nodes = new List<T>();


        public void Add(T newnode)
        {
            nodes.Add(newnode);
        }



        public int Indexof(T node)
        {
            int index1 = nodes.IndexOf(node);
            return index1;
        }

        public void Removenode(T node)
        {
            nodes.Remove(node);
        }

        public void Remove(T node)
        {
            nodes.Remove(node);
        }

        public void Insert(T v1, T v2)
        {
            nodes.Insert(1, v2);
        }
        public void printallnodes()
        {
            foreach (var a1 in nodes)
            {
                Console.WriteLine(a1.ToString());
            }
        }
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


    