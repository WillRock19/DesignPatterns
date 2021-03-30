namespace Decorator.Domain
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string Description { get; }
    }
}
