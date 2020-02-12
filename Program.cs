using System;

namespace Object_oriented_programs
{
    class Program
    {

  
        public static void Main(string[] args)
        {
            Console.WriteLine("OOPS concept:enter your choose");
            Console.WriteLine("1.Inventory\n2.InventoryManager\n3.DeckofCard\n4.DeckofCard using queue linkedlist\n5.stock\n6.StockUsingQueue\n7.Stock using LinkedList\n8.AdressBook");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    InventoryDetails id = new InventoryDetails();
                    id.Details();
                    break;
                case 2:
                    InventoryManager im = new InventoryManager();
                    im.Inventory_manager();
                    break;
                case 3:
                    DeckofCards dc = new DeckofCards();
                    dc.Cards();
                    break;
                case 4:
                    DeckofCardUsingQueueLink ql = new DeckofCardUsingQueueLink();
                    ql.DeckQueue();
                    break;
                case 5:
                    Stock s = new Stock();
                    s.Stock_All();
                    break;
                case 6:
                    StockusingQueue sq = new StockusingQueue();
                    sq.stockqueue();
                    break;
                case 7:
                    Stockaccusinglinkedlistcompanyshare sl= new Stockaccusinglinkedlistcompanyshare();
                    sl.Stockacc();
                    break;
                case 8:
                    Addressbook ab = new Addressbook();
                 //   ab.Adress();
                    break;


                case 9:
                    Sample M = new Sample();
                    M.ser();
                    break;
            }
        }
    }
}
 
