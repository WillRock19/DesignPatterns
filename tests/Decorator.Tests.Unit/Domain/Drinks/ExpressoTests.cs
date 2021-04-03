using Decorator.Domain.Drinks;
using FluentAssertions;
using NUnit.Framework;

namespace Decorator.Tests.Unit.Domain.Drinks
{
    class ExpressoTests
    {
        [Test]
        public void GetDescriptionShouldReturnDescriptionWithTextSettedInConstructor()
        {
            var expectedValue = "Expresso";
            var expresso = new Expresso();

            expresso.GetDescription().Should()
                .Be(expectedValue);
        }

        [Test]
        public void CostShouldReturnCorrectValue()
        {
            var expectedValue = 1.99M;
            var expresso = new Expresso();

            expresso.Cost().Should().Be(expectedValue);
        }
    }
}
