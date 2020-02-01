using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class Anagrams
    {
        static Boolean areanagrams(char[] str1, char[] str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            if (n1 != n2)
                return false;
            Array.Sort(str1);
            Array.Sort(str2);
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])                                                                        
                    return false;
            }

            return true;
        }
        public void checkanagram()
        {
            char []str1= {'h','e','a','r','t' };
            char[] str2 = {'e','a','r','t','h' };
            if (areanagrams(str1, str2)) 
            {
                Console.WriteLine("this a Anagram:" );
            }
            else
            {
                Console.WriteLine("not a Anagram");
            }                                                                                                                                                                                                                                                                   


        }
    }
}
