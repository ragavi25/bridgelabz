﻿// --------------------------------------------------------------------------------------------------------------------
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
    /// 
    /// </summary>
    public class ShopingCardImpl : ShoppingCartVisitor
    {
     /// <summary>
    /// 
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
        /// 
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
