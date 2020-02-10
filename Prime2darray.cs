//--------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name=" R Ragavi>
// -------
using System;

namespace Datastructure
{
    /// <summary>
    /// 
    /// </summary>
    class Prime2darray
    {
        /// <summary>
        ///purpose:Take a range of 0 - 1000 Numbers and find the Prime numbers in that range. Store the prime numbers in a 2D Array.
        ////// </summary>
        public void Primearray()
        {
            Console.Write("enter the row number");
            int m = Utility.Userrow();
            Console.Write("enter the col number");
            int n = Utility.Usercol();
            int[,] A = new int[m, n];
            ////1d array for storing m*n prime number
            int[] B = new int[m * n];
            int i = 0, j;
            int k = 0;
            while (i < (m * n))
            {
                if (Isprime(k) == true)
                {
                    B[i] = k;

                }
                k++;

            }

            ////for 2d Array
            int x = 0;
            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    A[i, j] = B[x];
                    x++;
                }
               
            }

            //Console.Write(" " + B[x]);
            Console.Write("The final Array is :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(" " + A[i, j] + "\t");
                }
                Console.ReadLine();

            }
        }
                static bool Isprime(int n)
                {
                    int count = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

        

    }
}