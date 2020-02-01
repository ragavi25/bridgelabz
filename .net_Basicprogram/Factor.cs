using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Factor
    {
        public void factors()
        {
            int N;
            Console.WriteLine("Enter a number");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= N; i += 2)
            {
                if (N % 2 == 0)
                {
                    Console.WriteLine(2);

                    N /= 2;
                }

                for (int j = 3; j <= Math.Sqrt(N); j += 2)
                {
                    while (N % j == 0)
                    {
                        Console.Write(j);
                        N /= j;
                    }
                }
            }

               // if (N > 2)
                {
                 //   Console.WriteLine(N);
                }
            }
            
        }
    }

                
            

        
    
