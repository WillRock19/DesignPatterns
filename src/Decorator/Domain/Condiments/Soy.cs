namespace Decorator.Domain.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost() 
            => 0.15M + _beverage.Cost();

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }
    }
}
