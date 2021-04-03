namespace Decorator.Domain.Drinks
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override decimal Cost() => 1.99M;
    }
}
