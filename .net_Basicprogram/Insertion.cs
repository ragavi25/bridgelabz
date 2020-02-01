using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class Insertion
    {
        public void insertionsort()
        {

            String[] arr = { "d","r", "a", "g", "ee", "s" };

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
                for (int j = i; j > 0; j--)
                {
              if (arr[j-1].CompareTo(arr[j])>0)
                {
           string   temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                }
              //arr[j + 1] = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "  ");
            }
        }
    }

}