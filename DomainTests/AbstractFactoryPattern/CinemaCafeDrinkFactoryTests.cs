using FluentAssertions;
using Patterns.Domain.AbstractFactoryPattern;
using Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

namespace Patterns.DomainTests.AbstractFactoryPattern;

public class CinemaCafeDrinkFactoryTests
{
    private readonly CinemaCafeDrinkFactory _cinemaCafeDrinkFactory;
    
    public CinemaCafeDrinkFactoryTests()
    {
        _cinemaCafeDrinkFactory = new CinemaCafeDrinkFactory();
    }
    [Fact]
    public void ShouldReturnBlackTeaType_CreateTeaTest()
    {
        var result = _cinemaCafeDrinkFactory.CreateTea();
        result.Should().BeOfType(typeof(BlackTea));
    }
    
    [Fact]
    public void ShouldReturnAmericanoCoffeeType_CreateCoffeeTest()
    {
        var result = _cinemaCafeDrinkFactory.CreateCoffee();
        result.Should().BeOfType(typeof(AmericanoCoffee));
    }
}