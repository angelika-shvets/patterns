using FluentAssertions;
using Patterns.Domain.AbstractFactoryPattern;

namespace Patterns.DomainTests.AbstractFactoryPattern;

public class CafeFactoryBootstrapTests
{
    private const int TheatreCafeType = 1;
    private const int CinemaCafeType = 2;
    
    public CafeFactoryBootstrapTests()
    {
    }
    [Fact]
    public async Task ShouldReturnCinemaCafeDrinkProvider_CreateTest()
    {
        var cafeFactoryBootstrap = new CafeFactoryBootstrap(CinemaCafeType);
        var test = await cafeFactoryBootstrap.GetTeaDescription();
        test.Should().Be(
            "Black Tea is the most common type of tea accounting for up to 85% of total tea consumption in the western world.");
        //cafeFactoryBootstrap.Should().BeOfType(typeof(CafeDrinkProvider));
    }
    [Fact]
    public void ShouldReturnTheatreCafeDrinkProvider_CreateTest()
    {
        var cafeFactoryBootstrap = new CafeFactoryBootstrap(TheatreCafeType);
        cafeFactoryBootstrap.Should().BeOfType(typeof(CafeDrinkProvider));
    }
}