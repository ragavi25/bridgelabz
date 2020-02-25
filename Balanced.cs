//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Balanced.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name=" R Ragavi>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections;

namespace Datastructure
{
    /// <summary>
    /// purpose :Take an Arithmetic Expression such as (5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3) where parentheses are used to order the performance of operations. Ensure parentheses must appear in a balanced fashion.

    /// </summary>
    class Balanced
    {
        /// <summary>
        /// purpose:Write a Stack Class to push open parenthesis “(“ and pop closed parenthesis “)”. At the End of the Expression if the Stack is Empty then the Arithmetic Expression is Balanced. Stack Class Methods are Stack(), push(), pop(), size()

        /// </summary>
        public void Parenthesis()
        {
            ////(5 + 6)∗(7 + 8) / (4 + 3)(5 + 6)∗(7 + 8) / (4 + 3)
            char[] exp = { '(', ')', '(', ')', '(', ')','(',')','(',')','(',')' };
            if (Areparenthesis(exp))
                Console.WriteLine("Balanced ");
            else
                Console.WriteLine("Not Balanced ");
        }

        private static bool Areparenthesis(char[] exp)
        {
            Stack st = new Stack();
            for (int i = 0; i < exp.Length; i++)
            {
                if ( exp[i] == '(' )
                    st.Push(exp[i]);
                if ( exp[i] == ')')
                {
                    if (st.Count == 0)
                    {
                        return false;

                    }
                    else if (!Ismatchingpair(exp[i], exp[i]))
                    {
                        _ = st.Pop();

                        return false;
                    }
                }
            }
            if (st.Count == 0)
                return true;

            else
            {

                return false;
            }
           
        }
        static Boolean Ismatchingpair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public int top = -1;
        public char[] items = new char[100];

        public void Push(char x)
        {
            if (top == 99)
            {
                Console.WriteLine("Stack full");
            }
            else
            {
                items[++top] = x;
            }
        }

       public char Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Underflow error");
                return '0';
            }
            else
            {
                char element = items[top];
                top--;
                return element;
            }
        }
    }
}
    

