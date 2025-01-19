namespace Patterns.Domain;

public interface ICoffee
{
    Task Add(string compound);
    
    Task Reset();
    Task<string> GetCoffee();
}