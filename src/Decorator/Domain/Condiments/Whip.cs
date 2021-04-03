namespace Decorator.Domain.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost() 
            => 0.10M + _beverage.Cost();

        public override string GetDescription() =>
            $"{_beverage.GetDescription()}, Whip";
    }
}
