using FluentAssertions;
using Patterns.Domain.AbstractFactoryPattern;
using Patterns.Domain.AbstractFactoryPattern.CafeDrinks;

namespace Patterns.DomainTests.AbstractFactoryPattern;

public class TheatreCafeDrinkFactoryTests
{
    private readonly TheatreCafeDrinkFactory _theatreCafeDrinkFactory;

    public TheatreCafeDrinkFactoryTests()
    {
        _theatreCafeDrinkFactory = new TheatreCafeDrinkFactory();
    }

    [Fact]
    public void ShouldReturnGreenTeaType_CreateTeaTest()
    {
        var result = _theatreCafeDrinkFactory.CreateTea();
        result.Should().BeOfType(typeof(GreenTea));
    }

    [Fact]
    public void ShouldReturnCappuccinoCoffeeType_CreateCoffeeTest()
    {
        var result = _theatreCafeDrinkFactory.CreateCoffee();
        result.Should().BeOfType(typeof(CappuccinoCoffee));
    }
}