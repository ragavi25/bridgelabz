// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class ShopingCardClient
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Test()
        {
            ItemElement[] items = new ItemElement[]
            {
                new Book(50,"2754"),
                new  Book(70,"2489"),
                new Fruit("Apple",2,100),
                new Fruit("Orange",1,80)
            };
            int Total = Calculate(items);
            Console.WriteLine("Total Cost: " + Total);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private static int Calculate(ItemElement[] items)
        {
            int sum = 0;
            ShoppingCartVisitor cartVisitor = new ShopingCardImpl();
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(cartVisitor);   
            }
            return sum;
        }
    }
}
