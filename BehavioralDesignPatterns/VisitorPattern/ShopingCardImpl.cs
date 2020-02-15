using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class ShopingCardImpl : ShoppingCartVisitor
    {
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

        public int Visit(Fruit fruit)
        {
            int cost = fruit.getPriceperkg() * fruit.getWeight();
            Console.WriteLine("Name: "+ fruit.getName() +"\n"+ "Cost =" + cost);
            return cost;
        }
    }
}
