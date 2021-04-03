namespace Decorator.Domain.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost() 
            => 0.20M + _beverage.Cost();

        public override string GetDescription() => 
            $"{_beverage.GetDescription()}, Mocha";
    }
}
