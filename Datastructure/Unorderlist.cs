// --------------------------------------------------------------------------------------------------------------------
// <copyright file= Unorderlist.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{ 
    /// <summary>
    /// purpose: Create a Unordered Linked List. 
    /// </summary>
    class Unorderlist
    {

        /// <summary>
        /// purpose:The Basic Building Block is the Node Object. Each node object must hold at least two pieces of information. One ref to the data field and  second the ref to the next node object
        /// </summary>
        public void Unorder()
        {
            ////Create a nodelist
            NoteList<string> a = new NoteList<string>();
                a.Add("IT");
                a.Add("CSC");
                a.Add("ECE");
                a.Add("EEE");
                a.Add("AUTO");
                a.printallnodes();
                Console.WriteLine("-------------------REMOVE--------------------------");
                a.Remove("IT");
                a.printallnodes();
                Console.WriteLine("-------------------INDEXOF-------------------------");
                int index1 = a.Indexof("CSC");
                Console.WriteLine(index1);
                a.Search("ECE");
                a.printallnodes();
                Console.WriteLine("-------------------INSERT-------------------------");
                a.Insert("1", "MECH");
                a.printallnodes();
                Console.WriteLine("------------------------------------");
                a.isEmpty();
                a.printallnodes();

            

            }

        }
}
