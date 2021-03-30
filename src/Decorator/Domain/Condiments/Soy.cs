namespace Decorator.Domain.Condiments
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public override string Description
        {
            get => $"{_beverage.Description}, Soy";
        }

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost() 
            => 0.15 + _beverage.Cost();
    }
}
