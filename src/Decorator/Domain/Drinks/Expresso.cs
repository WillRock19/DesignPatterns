namespace Decorator.Domain.Drinks
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override double Cost() => 1.99;
    }
}
