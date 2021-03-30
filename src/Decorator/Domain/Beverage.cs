namespace Decorator.Domain
{
    public abstract class Beverage
    {
        public string Description { get; protected set; }
        public abstract double Cost();
    }
}
