using System;

namespace Datastructure
{
    class Program
    {

        public static void Main(String[] args)

        {
            Console.WriteLine("ENTER YOUR CHOICE:\n1.unorderlist\n2.orderlist\n3.simplebalancedparathesis\n4.primearray\n5:Bankingcashcounter:\n6.Calendar\n7.BinarySearchTree\n8.Palindrome checker\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Unorderlist u = new Unorderlist();
                    u.Unorder();
                    break;
                case 2:
                    Orderlist ol = new Orderlist();
                    ol.Order();
                    break;
                case 3:
                    Balanced pc = new Balanced();
                    pc.Parenthesis();
                    break;
                case 4:
                    Prime2darray pd = new Prime2darray();
                    pd.Primearray();
                    break;
                case 5:
                    Bankingcashcounter bc = new Bankingcashcounter();
                    bc.Bank();
                    break;
                case 6:
                    Calendar c = new Calendar();
                    c.Showcalendar();
                    break;
                case 7:
                    Binarysearchtree bst = new Binarysearchtree();
                    bst.Binarysearch();
                    break;
                case 8:
                    PalindromeChecker p1 = new PalindromeChecker();
                    p1.Checker();
                        break; ;




            }

        }
    }
}
