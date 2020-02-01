using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programs
{
    class _2dmatrix
    {
        public void array()
        {
            int m, n, i, j;
            Console.WriteLine("enter m value");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m, n];
            int[,] A = new int[m, n];
            Console.WriteLine("enter A matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write( A[i, j]+" ");
                }
                Console.WriteLine();
            }
            
            int[,] B = new int[m, n];
            Console.WriteLine("enter B matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix result:");
            int[,] C = new int[m, n];
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    C[i, j] = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    for (int k = 0; k < m; k++)
                    {
                        C[i, j] += A[i, j] * B[i, j];
                    }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(" " + C[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        

    }
}
