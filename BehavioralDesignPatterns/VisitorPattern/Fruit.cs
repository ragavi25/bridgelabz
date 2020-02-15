﻿namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Fruit : ItemElement
    {
        private string Name;
        private int Weight;
        private int Priceperkg;
        private string v1;
        private string v2;
        private int v3;
        private int v;

        
        public Fruit(string Name, int Weight, int Priceperkg)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Priceperkg = Priceperkg;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getWeight()
        {
            return Weight;
        }
        public int getPriceperkg()
        {
            return Priceperkg;
        }
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}