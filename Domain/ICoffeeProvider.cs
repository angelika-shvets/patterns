namespace Patterns.Domain;

public interface ICoffeeProvider
{
    Task<string> MakeCoffeeByName(string coffee);
    
 //   Task<string> GetCoffeeDescriptionByName(string coffee);
}