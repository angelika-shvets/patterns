
namespace Patterns.Domain.VisitorPattern;

public interface IVisitor
{
    Task Visit(AmericanoCoffee americanoCoffee);
    Task Visit(CappuccinoCoffee cappuccinoCoffee);
}