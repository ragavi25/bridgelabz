using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class Bubblesort
    {
        public void bubblesort()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
