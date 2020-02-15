using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class ShopingCardClient
    {
        public static void Test()
        {
            ItemElement[] items = new ItemElement[]
            {
                new Book(50,"2754"),
                new  Book(70,"2489"),
                new Fruit("Apple","2kg",100),
                new Fruit("Orange","1kg",80)
            };
            int Total = Calculate(items);
            Console.WriteLine("Total Cost: " + Total);
        }

        private static int Calculate(ItemElement[] items)
        {
            int sum = 0;
            ShoppingCartVisitor cartVisitor = new ShopingCardImpl();
            foreach (ItemElement item in items)
            {
                
            }
            return sum;
        }
    }
}
