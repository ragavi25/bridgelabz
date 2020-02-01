using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programs
{
    class Sumofthree
    {
        public void sumofthreenum()
        {
            int i, j, k;
            int[] arr = { 0, -1, 2, -3, 1 };
            Boolean found = true;
            for ( i = 0; i <= arr.Length - 2; i++)
            {
                for ( j = 0; j <= arr.Length - 1; j++)
                {
                    for ( k = 0; k <= arr.Length; k++)
                    {
                       
                            if(arr[i] + arr[j] + arr[k] ==0)

                        Console.WriteLine(arr[i]);
                        Console.WriteLine("");
                        Console.WriteLine(arr[j]);
                        Console.WriteLine("");
                        Console.WriteLine(arr[k]);
                        found = true;

                    }
                }
            }
                            
            found = false;

                            Console.WriteLine("");

                            if (found == false)
                            {
                                Console.WriteLine(" Not EXIT");
                            }


                        
        }
    }
}


