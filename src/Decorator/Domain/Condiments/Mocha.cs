namespace Decorator.Domain.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public override string Description
        {
            get => $"{_beverage.Description}, Mocha";
        }

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost() => 0.20 + _beverage.Cost();
    }
}
