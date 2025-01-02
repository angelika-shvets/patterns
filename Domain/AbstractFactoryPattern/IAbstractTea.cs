namespace Patterns.Domain.AbstractFactoryPattern;

public interface IAbstractTea
{
    Task<string> GetTeaDescription();
}