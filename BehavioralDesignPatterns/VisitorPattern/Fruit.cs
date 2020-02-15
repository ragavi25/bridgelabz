namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Fruit : ItemElement
    {
        private string Name;
        private int Weight;
        private int Priceperkg;
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