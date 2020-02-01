using System;

namespace AlogrithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
        hii:
            Console.WriteLine("Enter the opption:\n1:Binarysearch\t2:insertionsort\t3:bubblesort\t4:Mergesort\t5:Anagrams\t 6:primenumber\t7:Question s or no");
            int op1 = Convert.ToInt32(Console.ReadLine());
            switch (op1)
            {
                case 1:
                    BinarySearch bs = new BinarySearch();
                    bs.binarysearch1();
                    break;
                case 2:
                    Insertion iser= new Insertion();
                    iser.insertionsort();
                    break;
                case 3:
                    Bubblesort B= new Bubblesort();
                    B.bubblesort();
                    break;
                case 4:
                    Mergesort ob = new Mergesort();
                    ob.mergesort();
                    break;
                case 5:
                    Anagrams a = new Anagrams();
                    a.checkanagram();
                    break;
                case 6:
                    Primenumber pn = new Primenumber();
                    pn.prime();
                    break;

                case 7:
                    Question q = new Question();
                    q.ques();
                    break;
            }
            goto hii;
        }

    }
}
            