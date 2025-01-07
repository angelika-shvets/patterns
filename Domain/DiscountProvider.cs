using Patterns.Domain.VisitorPattern;

namespace Patterns.Domain;

public class DiscountProvider : IDiscountProvider
{
    private readonly IVisitor _visitor;

    public DiscountProvider(IVisitor visitor)
    {
        _visitor = visitor;
    }

    public async Task GetMembershipDiscount(IVisitable coffee)
    {
        await coffee.Accept(_visitor);
    }
}