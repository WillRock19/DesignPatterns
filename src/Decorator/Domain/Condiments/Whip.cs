namespace Decorator.Domain.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public override string Description
        {
            get => $"{_beverage.Description}, Whip";
        }

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost() 
            => 0.10 + _beverage.Cost();
    }
}
