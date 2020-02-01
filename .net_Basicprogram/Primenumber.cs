using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
	class Primenumber
	{
		public void prime()
		{
            int num, i, count ;
            int sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");
            for (num = 0;num <= 1000;num++)
            {
                count = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count==0& num!=1)
                    Console.Write("{0} ", num);
            }
            hi:
            Console.WriteLine("enter your choice:\t1:Anagrams\t2:Palindrome");
            int opp3 = Convert.ToInt32(Console.ReadLine());
            switch (opp3)
            {

                case 1:
                    for ( i = num;i>0;i/= 10)
                    {
                        sum=sum*10+ i % 10;
                    }
                       
                        Console.WriteLine("it is a anagrams:" + sum);
                       
                        break;
                case 2:
                    for (i = num; i > 0; i /= 10)
                    {
                        sum = sum * 10 + i % 10;
                    }
                    if (sum == num)
                    {
                        Console.WriteLine("it is a palindrome:" + num);
                    }
                    else
                    {
                        Console.WriteLine("not a palindrome" + num);
                    }
                    break;
            }

            goto hi;
                      
            
        }
        








        }
		
	}


    

