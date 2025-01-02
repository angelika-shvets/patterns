using FluentAssertions;
using Moq;
using Patterns.Domain.AbstractFactoryPattern;

namespace Patterns.DomainTests.AbstractFactoryPattern;

public class CafeDrinkProviderTests
{
    private const string CoffeeDescription = "Some coffee description";
    private const string TeaDescription = "Some tea description";

    private readonly Mock<IAbstractFactory> _abstractFactory;
    private readonly Mock<IAbstractCoffee> _abstractCoffee;
    private readonly Mock<IAbstractTea> _abstractTea;

    private readonly ICafeDrinkProvider _cafeDrinkProvider;

    public CafeDrinkProviderTests()
    {
        _abstractFactory = new Mock<IAbstractFactory>();
        _abstractCoffee = new Mock<IAbstractCoffee>();
        _abstractTea = new Mock<IAbstractTea>();

        _abstractFactory.Setup(x => x.CreateCoffee()).Returns(_abstractCoffee.Object);
        _abstractFactory.Setup(x => x.CreateTea()).Returns(_abstractTea.Object);

        _cafeDrinkProvider = new CafeDrinkProvider(_abstractFactory.Object);
    }

    [Fact]
    public async Task ShouldGetCoffeeDescription_GetCoffeeDescriptionTest()
    {
        _abstractCoffee.Setup(x => x.GetCoffeeDescription()).ReturnsAsync(CoffeeDescription);

        var result = await _cafeDrinkProvider.GetCoffeeDescription();

        _abstractFactory.Verify(x => x.CreateCoffee(), Times.Once);
        _abstractCoffee.Verify(x => x.GetCoffeeDescription(), Times.Once);
        result.Should().Be(CoffeeDescription);
    }

    [Fact]
    public async Task ShouldGetTeaDescription_GetTeaDescriptionTest()
    {
        _abstractTea.Setup(x => x.GetTeaDescription()).ReturnsAsync(TeaDescription);

        var result = await _cafeDrinkProvider.GetTeaDescription();

        _abstractFactory.Verify(x => x.CreateTea(), Times.Once);
        _abstractTea.Verify(x => x.GetTeaDescription(), Times.Once);
        result.Should().Be(TeaDescription);
    }
}