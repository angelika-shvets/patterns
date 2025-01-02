namespace Patterns.Domain.AbstractFactoryPattern;

public interface ICafeDrinkProvider
{
    public Task<string> GetTeaDescription();
    
    public Task<string> GetCoffeeDescription();
}