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
    /// <summary>
    ///  we will implement visitor interface and every item will have it’s own logic to calculate the cost.
    /// </summary>
    public class ShopingCardImpl : ShoppingCartVisitor
    {
     /// <summary>
    /// purpose:Visit method used to get book value.
    /// </summary>
    /// <param name="book"></param>
    /// <returns></returns>
        public int Visit(Book book)
        {
            
            int price = 0;
            if(book.getCost() > 100)
            {
                price = book.getCost() - 10;
            }
            else
            {
                price = book.getCost();
            }
            Console.WriteLine("BOOK ISBN:" + book.getISBNumber() +" \n " + "Price:" + price);
            return price;


        }
        /// <summary>
        /// Visit method used to get the furit value.
        /// </summary>
        /// <param name="fruit"></param>
        /// <returns></returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.getPriceperkg() * fruit.getWeight();
            Console.WriteLine("Name: "+ fruit.getName() +"\n"+ "Cost =" + cost);
            return cost;
        }
    }
}
