using Decorator.Domain.Drinks;
using FluentAssertions;
using NUnit.Framework;

namespace Decorator.Tests.Unit.Domain.Drinks
{
    class DarkRoastTests
    {
        [Test]
        public void GetDescriptionShouldReturnDescriptionWithTextSettedInConstructor()
        {
            var expectedValue = "Dark Roast Coffee";
            var expresso = new DarkRoast();

            expresso.GetDescription().Should()
                .Be(expectedValue);
        }

        [Test]
        public void CostShouldReturnCorrectValue()
        {
            var expectedValue = 0.99M;
            var expresso = new DarkRoast();

            expresso.Cost().Should().Be(expectedValue);
        }
    }
}
