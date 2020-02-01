using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class BinarySearch
    {
        public void binarysearch1()
        {
            String[] arr = { "ragavi", "ramya", "ramki", "ragu", "leela", "sadhrah" };
            Console.WriteLine("enter a key:");
            String key = Utility.Userkey();
           //key = Console.ReadLine();
            int result = binarysearch2(arr, key);
            if (result == -1)
            {
                Console.WriteLine("Element is a not present");
            }
            else
                Console.WriteLine("Element is present:" + result);
        }
         public   static int binarysearch2(String []arr, String key)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    int res = key.CompareTo(arr[mid]);

                    // Check if x is present at mid  
                    if (res == 0)
                    {
                       return mid;
                    }
                    // If x greater, ignore left half  
                    if (res > 0)
                    {
                        left = mid + 1;
                    }
                    // If x is smaller, ignore right half  
                    else
                    {
                        right = mid - 1;
                    }

                }
            return -1;
        
        }
    }
}
