namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Fruit : ItemElement
    {
        private string Name;
        private int Weight;
        private string Priceperkg;
        public string getName()
        {
            return this.Name;
        }
        public int getWeight()
        {
            return Weight;
        }
        public string getPriceperkg()
        {
            return Priceperkg;
        }
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}