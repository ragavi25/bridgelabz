namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Book : ItemElement
    {
        private int Cost;
        private string ISBNumber;
       public int getCost()
        {
            return Cost;
        }
        public string getISBNumber()
        {
            return ISBNumber;
        }
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}