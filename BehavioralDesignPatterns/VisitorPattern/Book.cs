namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Book : ItemElement
    {
        private readonly int Cost;
        private readonly string ISBNumber;
        private readonly int v1;
        private readonly string v2;

        public Book(int Cost, string ISBNumber)
        {
            this.Cost = Cost;
            this.ISBNumber= ISBNumber;
        }

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