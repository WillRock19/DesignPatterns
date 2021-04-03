using Decorator.Domain.Drinks;
using FluentAssertions;
using NUnit.Framework;

namespace Decorator.Tests.Unit.Domain.Drinks
{
    class HouseBlendTests
    {
        [Test]
        public void GetDescriptionShouldReturnDescriptionWithTextSettedInConstructor() 
        {
            var expectedValue = "House Blend Coffee";
            var houseBlend = new HouseBlend();

            houseBlend.GetDescription().Should()
                .Be(expectedValue);
        }

        [Test]
        public void CostShouldReturnEigthyNineCents() 
        {
            var expectedValue = 0.89M;
            var houseBlend = new HouseBlend();

            houseBlend.Cost().Should().Be(expectedValue);
        }
    }
}
