namespace Decorator.Domain.Drinks
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost() => 0.99;
    }
}
