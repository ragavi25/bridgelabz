// --------------------------------------------------------------------------------------------------------------------
// <copyright file=.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="J Raghul"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
     public class Orderlist
    {
        public void Order()
        {

            NoteList<Integer> n = new NoteList<Integer>();
            int num = Utility.Readfile();
            while (num!=0)
            { 
                n.Add(num=(Convert.ToInt32(Console.ReadLine())));
            }










        }

    }
}
