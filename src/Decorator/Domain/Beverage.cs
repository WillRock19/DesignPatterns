namespace Decorator.Domain
{
    public abstract class Beverage
    {
        protected string Description { get; set; }

        public virtual string GetDescription() 
            => Description;

        public abstract decimal Cost();
    }
}
