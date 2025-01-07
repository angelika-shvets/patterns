namespace Patterns.Domain.VisitorPattern;

public interface IVisitable
{
    Task Accept(IVisitor visitor);
}